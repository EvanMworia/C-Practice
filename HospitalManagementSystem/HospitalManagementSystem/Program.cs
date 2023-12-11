using HospitalManagementSystem.ConsoleUi;
using HospitalManagementSystem.Data;

ConsoleUiController ui=new ();
DataContext context = new();

ui.userInterface(context);
