using MS4SArgHasher.Actions;

string[] arguments = Environment.GetCommandLineArgs();

Console.WriteLine("[INFO] Arguments received: {0}", string.Join(", ", arguments));

new ArgumentAction().SetData(arguments);