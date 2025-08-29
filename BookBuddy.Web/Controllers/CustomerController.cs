using Microsoft.AspNetCore.Mvc;
using BookBuddy.UserStories.Customers.GetCustomer;
using BookBuddy.UserStories.Customers.CreateCustomer;
using BookBuddy.UserStories.Customers.UpdateCustomer;

namespace BookBuddy.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly GetCustomerUserStory _getCustomerUserStory;
    private readonly CreateCustomerUserStory _createCustomerUserStory;
    private readonly UpdateCustomerUserStory _updateCustomerUserStory;

    public CustomerController(
        GetCustomerUserStory getCustomerUserStory,
        CreateCustomerUserStory createCustomerUserStory,
        UpdateCustomerUserStory updateCustomerUserStory)
    {
        _getCustomerUserStory = getCustomerUserStory;
        _createCustomerUserStory = createCustomerUserStory;
        _updateCustomerUserStory = updateCustomerUserStory;
    }

    // Exemplo: GetById
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var input = new GetCustomerInput { CustomerId = id };
        var customer = await _getCustomerUserStory.Execute(input);
        if (customer == null)
            return NotFound();
        return Ok(customer);
    }

    // Exemplo: Create
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCustomerInput input)
    {
        var output = await _createCustomerUserStory.Execute(input);
        return CreatedAtAction(nameof(GetById), new { id = output.Id }, output);
    }

    // Exemplo: Update
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateCustomerInput input)
    {
        if (id != input.Id)
            return BadRequest();
        var output = await _updateCustomerUserStory.Execute(input);
        return Ok(output);
    }

    // Métodos de listagem e delete podem ser implementados conforme UserStories disponíveis
}
