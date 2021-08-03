public class Circle
{
    private List<Users> members;
    public bool IsFull()
    {
        // 別のメソッドも使う
        return CountMembers() >= 30;
    }
    public int CountMembers()
    {
        // 常に1名は管理者なのがこれでコードからも読み取れる...？
        return members.Count + 1;
    }
}