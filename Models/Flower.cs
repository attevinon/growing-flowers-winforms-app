using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Models
{
    public class Flower
    {
        public static Dictionary<string, Flower> Flowers { get; } = new Dictionary<string, Flower>(3);
        public string Name { get ; private set; }
        public FlowerColor Color { get; }
        internal IEcologyGroup EcoGroup { get; }
        internal GrowthRateType GrowthRate { get; }
        internal GrowthStage Stage { get; private set; }

        private int wateringCounter = 0;
        public bool IsWatered { get; private set; } = false;

        public Action<int> FlowerGrown { get; set; }

        public Flower(string name, int colorIndex)
        {
            Enum.TryParse($"{colorIndex}", out FlowerColor color);

            Color = color;
            Name = name;

            switch (color)
            {
                case FlowerColor.Red:
                    GrowthRate = GrowthRateType.Fast;
                    EcoGroup = new Xerophyte();
                    break;
                case FlowerColor.Blue:
                    GrowthRate = GrowthRateType.Slow;
                    EcoGroup = new Hygrophyte();
                    break;
                case FlowerColor.Yellow:
                    GrowthRate = GrowthRateType.Medium;
                    EcoGroup = new Xerophyte();
                    break;
                default:
                    GrowthRate = GrowthRateType.Medium;
                    EcoGroup = new Mesophyte();
                    break;
            }

            Stage = new SproutStage(this);
            Flowers.Add(Name, this);
        }

        private void Growing()
        {
            Stage.Grow();
            FlowerGrown?.Invoke(Stage.Id);
        }
        internal void ChangeGrowthStage(GrowthStage stage)
        {
            Stage = stage;
        }

        public async Task WateringAsync()
        {
            if (IsWatered == true)
            {
                await Task.Run(() => Thread.Sleep(EcoGroup.SoilDryingTime));
                IsWatered = false;
                return;
            }

            IsWatered = true;
            wateringCounter++;

            if (wateringCounter == EcoGroup.TheRequiredAmountOfWatering)
            {
                Task.Run(() => Growing());
                wateringCounter = 0;
            }

            await Task.Run(() => Thread.Sleep(EcoGroup.SoilDryingTime));

            IsWatered = false;
        }

        public void Delete()
        {
            Flowers.Remove(Name);
        }
    }

    internal enum GrowthRateType
    {
        Fast = 5000,
        Medium = 10000,
        Slow = 15000
    }


}
