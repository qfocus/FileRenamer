﻿namespace FileRenamer
{
    class Target
    {

        public Target(string original, string target)
        {
            this.OriginalName = original;
            this.TargetName = target;
        }

        public override string ToString()
        {
            return TargetName;
        }

        public string OriginalName { get; set; }
        public string TargetName { get; set; }
    }
}
