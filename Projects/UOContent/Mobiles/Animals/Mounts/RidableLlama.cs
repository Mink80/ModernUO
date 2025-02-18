namespace Server.Mobiles
{
    public class RidableLlama : BaseMount
    {
        public override string DefaultName => "a ridable llama";

        [Constructible]
        public RidableLlama() : base(0xDC, 0x3EA6, AIType.AI_Animal, FightMode.Aggressor
        )
        {
            BaseSoundID = 0x3F3;

            SetStr(21, 49);
            SetDex(56, 75);
            SetInt(16, 30);

            SetHits(15, 27);
            SetMana(0);

            SetDamage(3, 5);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 10, 15);
            SetResistance(ResistanceType.Fire, 5, 10);
            SetResistance(ResistanceType.Cold, 5, 10);
            SetResistance(ResistanceType.Poison, 5, 10);
            SetResistance(ResistanceType.Energy, 5, 10);

            SetSkill(SkillName.MagicResist, 15.1, 20.0);
            SetSkill(SkillName.Tactics, 19.2, 29.0);
            SetSkill(SkillName.Wrestling, 19.2, 29.0);

            Fame = 300;
            Karma = 0;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = 29.1;
        }

        public RidableLlama(Serial serial) : base(serial)
        {
        }

        public override string CorpseName => "a llama corpse";

        public override int Meat => 1;
        public override int Hides => 12;
        public override FoodType FavoriteFood => FoodType.FruitsAndVegies | FoodType.GrainsAndHay;

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}
