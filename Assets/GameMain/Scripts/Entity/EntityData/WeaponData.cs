﻿using GameFramework.DataTable;
using System;
using UnityEngine;

namespace AirForce
{
    [Serializable]
    public class WeaponData : AccessoryObjectData
    {
        [SerializeField]
        private int m_Attack = 0;

        [SerializeField]
        private float m_AttackInterval = 0f;

        [SerializeField]
        private int m_BulletId = 0;

        public WeaponData(int entityId, int typeId, int ownerId)
            : base(entityId, typeId, ownerId)
        {
            IDataTable<DRWeapon> dtWeapon = GameEntry.DataTable.GetDataTable<DRWeapon>();
            DRWeapon drWeapon = dtWeapon.GetDataRow(TypeId);
            if (drWeapon == null)
            {
                return;
            }

            m_Attack = drWeapon.Attack;
            m_AttackInterval = drWeapon.AttackInterval;
            m_BulletId = drWeapon.BulletId;
        }

        /// <summary>
        /// 攻击力。
        /// </summary>
        public int Attack
        {
            get
            {
                return m_Attack;
            }
        }

        /// <summary>
        /// 攻击间隔。
        /// </summary>
        public float AttackInterval
        {
            get
            {
                return m_AttackInterval;
            }
        }

        /// <summary>
        /// 子弹编号。
        /// </summary>
        public int BulletId
        {
            get
            {
                return m_BulletId;
            }
        }
    }
}
