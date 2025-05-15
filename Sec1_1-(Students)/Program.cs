using StudentMangement;

List<Student> S = new List<Student>
{
    new Student(1, "Amr Ahmed", 20, "A"),
    new Student(2, "Ahmed Mahmoud", 22, "B"),
    new Student(3, "Abdurahman El-Masry", 23, "B+")
};
S[0].UpdateGrade("C+");
foreach (var item in S)
{
    item.DisplayInfo();
}