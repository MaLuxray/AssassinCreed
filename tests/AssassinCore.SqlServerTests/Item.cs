namespace AssassinCore.SqlServerTests
{
    public class Item : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int LogicId { get; set; } // 逻辑字符ID
    }
}