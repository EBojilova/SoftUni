// <copyright file="Battery.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>
      
namespace HWDefiningClassesTask02LaptopShop
{
    using System;

    public class Battery
    {
        private BatteryTypes type;
        private byte cells;
        private ushort capacity;

        public Battery(BatteryTypes type, byte cells, ushort capacity)
        {
            this.type = type;
            this.Cells = cells;
            this.Capacity = capacity;
        }

        public byte Cells
        {
            get 
            { 
                return this.cells; 
            }

            private set 
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Cells", "Cells can not be zero!");
                }

                this.cells = value; 
            }
        }

        public ushort Capacity
        {
            get 
            { 
                return this.capacity; 
            }

            private set 
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity", "Capacity can not be zero!");
                }

                this.capacity = value; 
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}-cells, {2} mAh", this.type, this.cells, this.capacity);
        }
    }
}
