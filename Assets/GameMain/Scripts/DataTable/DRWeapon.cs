﻿using GameFramework.DataTable;
using System.Collections.Generic;

namespace AirForce
{
    /// <summary>
    /// 武器表。
    /// </summary>
    public class DRWeapon : IDataRow
    {
        /// <summary>
        /// 武器编号。
        /// </summary>
        public int Id
        {
            get;
            private set;
        }

        /// <summary>
        /// 攻击力。
        /// </summary>
        public int Attack
        {
            get;
            private set;
        }

        /// <summary>
        /// 攻击间隔。
        /// </summary>
        public float AttackInterval
        {
            get;
            private set;
        }

        /// <summary>
        /// 子弹编号。
        /// </summary>
        public int BulletId
        {
            get;
            private set;
        }

        public void ParseDataRow(string dataRowText)
        {
            string[] text = DataTableExtension.SplitDataRow(dataRowText);
            int index = 0;
            index++;
            Id = int.Parse(text[index++]);
            index++;
            Attack = int.Parse(text[index++]);
            AttackInterval = float.Parse(text[index++]);
            BulletId = int.Parse(text[index++]);
        }

        private void AvoidJIT()
        {
            new Dictionary<int, DRWeapon>();
        }
    }
}
