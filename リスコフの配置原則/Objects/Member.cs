using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace リスコフの配置原則.Objects
{
    public abstract class Member
    {
        public enum MemberKind
        {
            Silver,
            Gold
        }

        public abstract int GetPoint(int price);

        public static Member Create(MemberKind kind)
        {
            if (kind == MemberKind.Gold)
            {
                return new Gold();
            }
            return new Silver();
        }
    }
}
