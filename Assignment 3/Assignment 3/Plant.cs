using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Plant
    {
        private int m_iGrowthRate;
        private int m_iProduce;
        private int m_iThirst;
        private int m_iNutrition;
        private float m_fSellRatio;
        private float m_fCost;

        public Plant()
        {
            m_iGrowthRate = 1;
            m_iProduce = 0;
            m_iThirst = 0;
            m_iNutrition = 0;
        }

        protected int GrowthRate
        {
            get
            {
                return m_iGrowthRate;
            }
            set
            {
                m_iGrowthRate = value;
            }
        }
        protected int Produce
        {
            get
            {
                return m_iProduce;
            }
            set
            {
                if (value < 0)
                {
                    m_iProduce = 0;
                }

                m_iProduce = value;
            }
        }
        protected int Thirst
        {
            get
            {
                return m_iThirst;
            }
            set
            {
                if (value < 0)
                {
                    m_iThirst = 0;
                }

                m_iThirst = value;
            }
        }
        protected int Nutrition
        {
            get
            {
                return m_iNutrition;
            }
            set
            {
                if (value < 0)
                {
                    m_iNutrition = 0;
                }

                m_iNutrition = value;
            }
        }
        protected float SellRatio
        {
            get
            {
                return m_fSellRatio;
            }
            set
            {
                m_fSellRatio = value;
            }
        }
        protected float Cost
        {
            get
            {
                return m_fCost;
            }
            set
            {
                m_fCost = value;
            }
        }

        public void Grow()
        {
            m_iProduce = m_iProduce + (1 * m_iGrowthRate);
        }

        protected void Harvest()
        {
            Produce = 0;
        }
        public void Water()
        {
            m_iThirst--;
        }
        public void Fertilize()
        {
            m_iNutrition++;
        }
    }
}
