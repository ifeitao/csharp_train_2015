class App
{
	static void Main()
	{
		Student s1 = new Student();
		Student s2 = new Student();
		System.Console.WriteLine(Student.MinAge);
		System.Console.WriteLine(s1.DefaultName);
		System.Console.WriteLine(s2.DefaultName);
	}
}
