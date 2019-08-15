using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Armadillo
{
    public unsafe partial class RandomGenerator : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 5072)]
        internal partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.MersenneTwisterEngine.__Internalc__N_std_S_mersenne_twister_engine__k_Vk64_Vk312_Vk156_Vk31_Vk13043109905998158313_Vk29_Vk6148914691236517205_Vk17_Vk8202884508482404352_Vk37_Vk18444473444759240704_Vk43_Vk6364136223846793005 engine;

            [FieldOffset(5008)]
            internal global::Std.UniformIntDistribution.__Internalc__N_std_S_uniform_int_distribution__I i_distr;

            [FieldOffset(5024)]
            internal global::Std.UniformRealDistribution.__Internalc__N_std_S_uniform_real_distribution__d u_distr;

            [FieldOffset(5040)]
            internal global::Std.NormalDistribution.__Internalc__N_std_S_normal_distribution__d n_distr;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0arma_rng_cxx11@arma@@QEAA@XZ")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0arma_rng_cxx11@arma@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?randi_val@arma_rng_cxx11@arma@@QEAAHXZ")]
            internal static extern int RandiVal(global::System.IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?randu_val@arma_rng_cxx11@arma@@QEAANXZ")]
            internal static extern double RanduVal(global::System.IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?randn_val@arma_rng_cxx11@arma@@QEAANXZ")]
            internal static extern double RandnVal(global::System.IntPtr __instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?randi_max_val@arma_rng_cxx11@arma@@SAHXZ")]
            internal static extern int RandiMaxVal();
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Armadillo.RandomGenerator> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Armadillo.RandomGenerator>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Armadillo.RandomGenerator __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Armadillo.RandomGenerator(native.ToPointer(), skipVTables);
        }

        internal static global::Armadillo.RandomGenerator __CreateInstance(global::Armadillo.RandomGenerator.__Internal native, bool skipVTables = false)
        {
            return new global::Armadillo.RandomGenerator(native, skipVTables);
        }

        private static void* __CopyValue(global::Armadillo.RandomGenerator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Armadillo.RandomGenerator.__Internal));
            *(global::Armadillo.RandomGenerator.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private RandomGenerator(global::Armadillo.RandomGenerator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected RandomGenerator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public RandomGenerator()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::Armadillo.RandomGenerator.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor((__Instance + __PointerAdjustment));
        }

        public RandomGenerator(global::Armadillo.RandomGenerator _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::Armadillo.RandomGenerator.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::Armadillo.RandomGenerator.__Internal*)__Instance) = *((global::Armadillo.RandomGenerator.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Armadillo.RandomGenerator __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int RandiVal
        {
            get
            {
                var __ret = __Internal.RandiVal((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public double RanduVal
        {
            get
            {
                var __ret = __Internal.RanduVal((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public double RandnVal
        {
            get
            {
                var __ret = __Internal.RandnVal((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public static int RandiMaxVal
        {
            get
            {
                var __ret = __Internal.RandiMaxVal();
                return __ret;
            }
        }
    }
}
