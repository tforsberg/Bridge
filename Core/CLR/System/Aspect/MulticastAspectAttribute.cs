﻿using System;
using Bridge.CLR;

namespace Bridge.Aspects
{
    /// <summary>
    /// 
    /// </summary>
    [Ignore]
    [Name("Bridge.Aspects.MultiAspectAttribute")]
    public abstract class MulticastAspectAttribute : AspectAttribute
    {
        public bool Exclude
        {
            get;
            set;
        }

        public int Inheritance
        {
            get;
            set;
        }

        public int Priority
        {
            get;
            set;
        }

        public bool Replace
        {
            get;
            set;
        }

        public int TargetMembersAttributes
        {
            get;
            set;
        }

        public string TargetMembers
        {
            get;
            set;
        }

        public int TargetParametersAttributes
        {
            get;
            set;
        }

        public string TargetParameters
        {
            get;
            set;
        }

        public int TargetTypesAttributes
        {
            get;
            set;
        }

        public string TargetTypes
        {
            get;
            set;
        }
    }
}