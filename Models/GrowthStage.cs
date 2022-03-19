using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Models
{
    internal abstract class GrowthStage
    {
        protected Flower flower;
        protected int growthRate;
        internal abstract int Id { get; }

        public GrowthStage(Flower flower)
        {
            this.flower = flower;
            growthRate = (int)flower.GrowthRate;
        }

        public abstract void Grow();
    }

    internal class SproutStage : GrowthStage
    {
        public SproutStage(Flower flower) : base(flower) { }
        internal override int Id { get; } = 1;

        public override void Grow()
        {
            Thread.Sleep(growthRate);
            flower.ChangeGrowthStage(new SeedingStage(flower));
        }
    }


    internal class SeedingStage : GrowthStage
    {
        public SeedingStage(Flower flower) : base(flower) { }
        internal override int Id { get; } = 2;

        public override void Grow()
        {
            Thread.Sleep(growthRate);
            flower.ChangeGrowthStage(new VegetativeStage(flower));
        }
    }

    internal class VegetativeStage : GrowthStage
    {
        public VegetativeStage(Flower flower) : base(flower) { }
        internal override int Id { get; } = 3;
        public override void Grow()
        {
            Thread.Sleep(growthRate);
            flower.ChangeGrowthStage(new BudStage(flower));
        }
    }

    internal class BudStage : GrowthStage
    {
        public BudStage(Flower flower) : base(flower) { }
        internal override int Id { get; } = 4;

        public override void Grow()
        {
            Thread.Sleep(growthRate);
            flower.ChangeGrowthStage(new BloomingStage(flower));
        }
    }


    internal class BloomingStage : GrowthStage
    {
        public BloomingStage(Flower flower) : base(flower) { }
        internal override int Id { get; } = 5;
        public override void Grow() { return; }
    }
}
