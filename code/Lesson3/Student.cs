public class Student
{
	public const int MinAge = 0;

	public static readonly int MaxAge;

	public readonly string DefaultName; 

	public static int Total;

	public string Name;

	public int Age;

	static Student()
	{
		Total = 0;
		MaxAge = 100;
	}

	public Student()
	{
		Total++;
		DefaultName = "Unkonwn" + Total.ToString();
		Name = "Unkonwn";
	}

	public int Method1()
	{
		return 0;
	}

	public int Method1(int number)
	{
		return number;
	}
	

	public string Method2(int number)
	{
		return number.ToString();
	}

	public static string Method3()
	{
		return "Student";
	}
}
