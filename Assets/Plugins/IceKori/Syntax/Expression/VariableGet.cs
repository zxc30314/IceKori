﻿using Assets.Plugins.IceKori.Common;

namespace Assets.Plugins.IceKori.Syntax.Expression
{
    [PageSlider]
    [System.Serializable]
    public class VariableGet : BaseExpression
    {
        public string Name;

        public VariableGet()
        {
            Reducible = true;
        }

        public VariableGet(string name)
        {
            Reducible = true;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public override BaseExpression Reduce(Enviroment env)
        {
            return env.FindVariable(Name);
        }
    }
}
