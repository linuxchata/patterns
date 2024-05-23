using Multiton;

var mainPrinter = Printer.Get(Subsystem.Main);
var backupPrinter = Printer.Get(Subsystem.Backup);

Console.ReadLine();
