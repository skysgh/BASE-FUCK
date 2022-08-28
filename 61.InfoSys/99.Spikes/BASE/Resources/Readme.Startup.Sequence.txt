# Dependencies
- Tools you may need are downloadable via script.
  See here [TODO]

# Startup Sequence
- Main() is in Program.cs of App.Host.Web
- A WebApplication is created first, and Services added.
- Note that Services need to be registered before .Build() is invoked.
- Note that .Map-ing is called after .Build.
