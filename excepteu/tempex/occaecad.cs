// Get the assembly for the current application.
Assembly assembly = Assembly.GetExecutingAssembly();

// Get the types in the assembly.
Type[] types = assembly.GetTypes();

// Get the methods in a type.
Type type = typeof(MyClass);
MethodInfo[] methods = type.GetMethods();

// Invoke a method on an object.
object obj = new MyClass();
MethodInfo method = type.GetMethod("MyMethod");
method.Invoke(obj, new object[] { 1, 2 });

// Create a new instance of a type.
Type type = typeof(MyClass);
object obj = Activator.CreateInstance(type);
