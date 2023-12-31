using System.Security.Cryptography.X509Certificates;

public enum MonsterType
{
    None,
    Slime,
    Orc,
    Skeleton
}

public class Monster : Creature
{
    protected MonsterType type = MonsterType.None;
    protected Monster(MonsterType type) : base(CreatureType.Monster)
    {
        this.type = type;
    }

    public MonsterType GetMonsterType() { return type; }
}

public class Slime : Monster
{
    public Slime() : base(MonsterType.Slime)
    {
        SetInfo(15, 10);
    }
}

public class Orc : Monster
{
    public Orc() : base(MonsterType.Orc)
    {
        SetInfo(25, 15);
    }
}

public class Skeleton : Monster
{
      public Skeleton() : base(MonsterType.Skeleton)
    {
        SetInfo(20, 25);
    }
}