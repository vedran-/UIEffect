using UnityEngine;

namespace Coffee.UIEffects
{
    public static class UnityPlayworkFix
    {
        private static Hash128 ZeroHash => new Hash128(0, 0, 0, 0);
        public static bool IsValid( this Hash128 hash ) => hash != ZeroHash;
    }
}