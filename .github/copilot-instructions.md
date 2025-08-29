use the one-line namespace without brackets pattern. Example: namespace BookBuddy.Domain.Cars;

When creating a Domain class, create it inside a folder with the same name as the main aggregate root class in the plural form (example: Car domain inside Cars folder). Add all classes at the root of that folder (i.e., Do not create subfolders).

In the project BookBuddy.Web, use UserStories as base for the Views and Controllers. Do not use domain classes directly in the Views or Controllers.

Always use class base constructors.
