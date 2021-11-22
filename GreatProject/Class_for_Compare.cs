﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
        class Compare_Materials : IComparer<Materials>
       {
            public int Compare(Materials p1, Materials p2)
            {
                   
            if (p1.price_of_Materials()> p2.price_of_Materials())
                {
                    return 1;
                } 
                else if (p1.price_of_Materials() < p2.price_of_Materials())
                {
                    return -1;
                }
                return 0;
            }
       }

        class Compare_Food: IComparer<Food>
    {
        public int Compare(Food p1, Food p2)
        {

            if (p1.price_of_item() > p2.price_of_item())
            {
                return 1;
            }
            else if (p1.price_of_item() < p2.price_of_item())
            {
                return -1;
            }
            return 0;
        }

        class Compare_Father : IComparer<Item>
        {
            public int Compare(Item p1, Item p2)
            {
                if (p1.price_of_item() > p2.price_of_item())
                {
                    return 1;
                }
                else if (p1.price_of_item() < p2.price_of_item())
                {
                    return -1;
                }
                return 0;
            }
        }
    }
    
}
