#Beginner course notes

`Platforms` folders enables to access platform specific APIs
`Resource` folder contains shared resources between platforms (fonts, img etc.). Conversion and scaling is handled by MAUI
`Resources/Styles` define colors and styles of the whole application

xaml files, like the auto generated main page, have "code behind" which is logic that executes on the html-like page

It uses MVVM architecture model to bind data and UI.
Installing `CommunityToolkit.Mvvm` makes the binding easier because it brings generators that automatically build code.
```
[ObservableProperty]
string? text;
```
nb. that this generates Text getters and setters, so in the main page it needs to be linked by doing:
```
<Entry 
	Placeholder="Enter task"
	Text="{Binding Text}"
	Grid.Row="1"/>
```

`addSingleton` will create a global class only once per execution
`addTransient` will create a class that gets destroyed automatically after use (detail pages for instance)

`nameof(className)` is a smart way to not have to refactor hardcoded strings when using class names

Routing is done into the `AppShell` like so:
```
 Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
```

Then we can write a command that goes to the page
```
await Shell.Current.GoToAsync(nameof(DetailsPage));

await Shell.Current.GoToAsync(".."); //Navigates back
```
