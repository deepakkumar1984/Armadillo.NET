using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Armadillo
{
    public unsafe partial class wrapper1
    {
        internal partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_sasum_")]
            internal static extern float WrapperSasum(int* n, float* x, int* incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_dasum_")]
            internal static extern double WrapperDasum(int* n, double* x, int* incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_snrm2_")]
            internal static extern float WrapperSnrm2(int* n, float* x, int* incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_dnrm2_")]
            internal static extern double WrapperDnrm2(int* n, double* x, int* incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_sdot_")]
            internal static extern float WrapperSdot(int* n, float* x, int* incx, float* y, int* incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_ddot_")]
            internal static extern double WrapperDdot(int* n, double* x, int* incx, double* y, int* incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_sgemv_")]
            internal static extern void WrapperSgemv([MarshalAs(UnmanagedType.LPStr)] string transA, int* m, int* n, float* alpha, float* A, int* ldA, float* x, int* incx, float* beta, float* y, int* incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_dgemv_")]
            internal static extern void WrapperDgemv([MarshalAs(UnmanagedType.LPStr)] string transA, int* m, int* n, double* alpha, double* A, int* ldA, double* x, int* incx, double* beta, double* y, int* incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_cgemv_")]
            internal static extern void WrapperCgemv([MarshalAs(UnmanagedType.LPStr)] string transA, int* m, int* n, global::System.IntPtr alpha, global::System.IntPtr A, int* ldA, global::System.IntPtr x, int* incx, global::System.IntPtr beta, global::System.IntPtr y, int* incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_zgemv_")]
            internal static extern void WrapperZgemv([MarshalAs(UnmanagedType.LPStr)] string transA, int* m, int* n, global::System.IntPtr alpha, global::System.IntPtr A, int* ldA, global::System.IntPtr x, int* incx, global::System.IntPtr beta, global::System.IntPtr y, int* incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_sgemm_")]
            internal static extern void WrapperSgemm([MarshalAs(UnmanagedType.LPStr)] string transA, [MarshalAs(UnmanagedType.LPStr)] string transB, int* m, int* n, int* k, float* alpha, float* A, int* ldA, float* B, int* ldB, float* beta, float* C, int* ldC);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_dgemm_")]
            internal static extern void WrapperDgemm([MarshalAs(UnmanagedType.LPStr)] string transA, [MarshalAs(UnmanagedType.LPStr)] string transB, int* m, int* n, int* k, double* alpha, double* A, int* ldA, double* B, int* ldB, double* beta, double* C, int* ldC);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_cgemm_")]
            internal static extern void WrapperCgemm([MarshalAs(UnmanagedType.LPStr)] string transA, [MarshalAs(UnmanagedType.LPStr)] string transB, int* m, int* n, int* k, global::System.IntPtr alpha, global::System.IntPtr A, int* ldA, global::System.IntPtr B, int* ldB, global::System.IntPtr beta, global::System.IntPtr C, int* ldC);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_zgemm_")]
            internal static extern void WrapperZgemm([MarshalAs(UnmanagedType.LPStr)] string transA, [MarshalAs(UnmanagedType.LPStr)] string transB, int* m, int* n, int* k, global::System.IntPtr alpha, global::System.IntPtr A, int* ldA, global::System.IntPtr B, int* ldB, global::System.IntPtr beta, global::System.IntPtr C, int* ldC);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_ssyrk_")]
            internal static extern void WrapperSsyrk([MarshalAs(UnmanagedType.LPStr)] string uplo, [MarshalAs(UnmanagedType.LPStr)] string transA, int* n, int* k, float* alpha, float* A, int* ldA, float* beta, float* C, int* ldC);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_dsyrk_")]
            internal static extern void WrapperDsyrk([MarshalAs(UnmanagedType.LPStr)] string uplo, [MarshalAs(UnmanagedType.LPStr)] string transA, int* n, int* k, double* alpha, double* A, int* ldA, double* beta, double* C, int* ldC);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_cherk_")]
            internal static extern void WrapperCherk([MarshalAs(UnmanagedType.LPStr)] string uplo, [MarshalAs(UnmanagedType.LPStr)] string transA, int* n, int* k, float* alpha, global::System.IntPtr A, int* ldA, float* beta, global::System.IntPtr C, int* ldC);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libarmadillo", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "wrapper_zherk_")]
            internal static extern void WrapperZherk([MarshalAs(UnmanagedType.LPStr)] string uplo, [MarshalAs(UnmanagedType.LPStr)] string transA, int* n, int* k, double* alpha, global::System.IntPtr A, int* ldA, double* beta, global::System.IntPtr C, int* ldC);
        }

        public static float WrapperSasum(ref int n, ref float x, ref int incx)
        {
            fixed (int* __n0 = &n)
            {
                var __arg0 = __n0;
                fixed (float* __x1 = &x)
                {
                    var __arg1 = __x1;
                    fixed (int* __incx2 = &incx)
                    {
                        var __arg2 = __incx2;
                        var __ret = __Internal.WrapperSasum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double WrapperDasum(ref int n, ref double x, ref int incx)
        {
            fixed (int* __n0 = &n)
            {
                var __arg0 = __n0;
                fixed (double* __x1 = &x)
                {
                    var __arg1 = __x1;
                    fixed (int* __incx2 = &incx)
                    {
                        var __arg2 = __incx2;
                        var __ret = __Internal.WrapperDasum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float WrapperSnrm2(ref int n, ref float x, ref int incx)
        {
            fixed (int* __n0 = &n)
            {
                var __arg0 = __n0;
                fixed (float* __x1 = &x)
                {
                    var __arg1 = __x1;
                    fixed (int* __incx2 = &incx)
                    {
                        var __arg2 = __incx2;
                        var __ret = __Internal.WrapperSnrm2(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double WrapperDnrm2(ref int n, ref double x, ref int incx)
        {
            fixed (int* __n0 = &n)
            {
                var __arg0 = __n0;
                fixed (double* __x1 = &x)
                {
                    var __arg1 = __x1;
                    fixed (int* __incx2 = &incx)
                    {
                        var __arg2 = __incx2;
                        var __ret = __Internal.WrapperDnrm2(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float WrapperSdot(ref int n, ref float x, ref int incx, ref float y, ref int incy)
        {
            fixed (int* __n0 = &n)
            {
                var __arg0 = __n0;
                fixed (float* __x1 = &x)
                {
                    var __arg1 = __x1;
                    fixed (int* __incx2 = &incx)
                    {
                        var __arg2 = __incx2;
                        fixed (float* __y3 = &y)
                        {
                            var __arg3 = __y3;
                            fixed (int* __incy4 = &incy)
                            {
                                var __arg4 = __incy4;
                                var __ret = __Internal.WrapperSdot(__arg0, __arg1, __arg2, __arg3, __arg4);
                                return __ret;
                            }
                        }
                    }
                }
            }
        }

        public static double WrapperDdot(ref int n, ref double x, ref int incx, ref double y, ref int incy)
        {
            fixed (int* __n0 = &n)
            {
                var __arg0 = __n0;
                fixed (double* __x1 = &x)
                {
                    var __arg1 = __x1;
                    fixed (int* __incx2 = &incx)
                    {
                        var __arg2 = __incx2;
                        fixed (double* __y3 = &y)
                        {
                            var __arg3 = __y3;
                            fixed (int* __incy4 = &incy)
                            {
                                var __arg4 = __incy4;
                                var __ret = __Internal.WrapperDdot(__arg0, __arg1, __arg2, __arg3, __arg4);
                                return __ret;
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperSgemv(string transA, ref int m, ref int n, ref float alpha, ref float A, ref int ldA, ref float x, ref int incx, ref float beta, ref float y, ref int incy)
        {
            fixed (int* __m1 = &m)
            {
                var __arg1 = __m1;
                fixed (int* __n2 = &n)
                {
                    var __arg2 = __n2;
                    fixed (float* __alpha3 = &alpha)
                    {
                        var __arg3 = __alpha3;
                        fixed (float* __A4 = &A)
                        {
                            var __arg4 = __A4;
                            fixed (int* __ldA5 = &ldA)
                            {
                                var __arg5 = __ldA5;
                                fixed (float* __x6 = &x)
                                {
                                    var __arg6 = __x6;
                                    fixed (int* __incx7 = &incx)
                                    {
                                        var __arg7 = __incx7;
                                        fixed (float* __beta8 = &beta)
                                        {
                                            var __arg8 = __beta8;
                                            fixed (float* __y9 = &y)
                                            {
                                                var __arg9 = __y9;
                                                fixed (int* __incy10 = &incy)
                                                {
                                                    var __arg10 = __incy10;
                                                    __Internal.WrapperSgemv(transA, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperDgemv(string transA, ref int m, ref int n, ref double alpha, ref double A, ref int ldA, ref double x, ref int incx, ref double beta, ref double y, ref int incy)
        {
            fixed (int* __m1 = &m)
            {
                var __arg1 = __m1;
                fixed (int* __n2 = &n)
                {
                    var __arg2 = __n2;
                    fixed (double* __alpha3 = &alpha)
                    {
                        var __arg3 = __alpha3;
                        fixed (double* __A4 = &A)
                        {
                            var __arg4 = __A4;
                            fixed (int* __ldA5 = &ldA)
                            {
                                var __arg5 = __ldA5;
                                fixed (double* __x6 = &x)
                                {
                                    var __arg6 = __x6;
                                    fixed (int* __incx7 = &incx)
                                    {
                                        var __arg7 = __incx7;
                                        fixed (double* __beta8 = &beta)
                                        {
                                            var __arg8 = __beta8;
                                            fixed (double* __y9 = &y)
                                            {
                                                var __arg9 = __y9;
                                                fixed (int* __incy10 = &incy)
                                                {
                                                    var __arg10 = __incy10;
                                                    __Internal.WrapperDgemv(transA, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperCgemv(string transA, ref int m, ref int n, global::System.IntPtr alpha, global::System.IntPtr A, ref int ldA, global::System.IntPtr x, ref int incx, global::System.IntPtr beta, global::System.IntPtr y, ref int incy)
        {
            fixed (int* __m1 = &m)
            {
                var __arg1 = __m1;
                fixed (int* __n2 = &n)
                {
                    var __arg2 = __n2;
                    fixed (int* __ldA5 = &ldA)
                    {
                        var __arg5 = __ldA5;
                        fixed (int* __incx7 = &incx)
                        {
                            var __arg7 = __incx7;
                            fixed (int* __incy10 = &incy)
                            {
                                var __arg10 = __incy10;
                                __Internal.WrapperCgemv(transA, __arg1, __arg2, alpha, A, __arg5, x, __arg7, beta, y, __arg10);
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperZgemv(string transA, ref int m, ref int n, global::System.IntPtr alpha, global::System.IntPtr A, ref int ldA, global::System.IntPtr x, ref int incx, global::System.IntPtr beta, global::System.IntPtr y, ref int incy)
        {
            fixed (int* __m1 = &m)
            {
                var __arg1 = __m1;
                fixed (int* __n2 = &n)
                {
                    var __arg2 = __n2;
                    fixed (int* __ldA5 = &ldA)
                    {
                        var __arg5 = __ldA5;
                        fixed (int* __incx7 = &incx)
                        {
                            var __arg7 = __incx7;
                            fixed (int* __incy10 = &incy)
                            {
                                var __arg10 = __incy10;
                                __Internal.WrapperZgemv(transA, __arg1, __arg2, alpha, A, __arg5, x, __arg7, beta, y, __arg10);
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperSgemm(string transA, string transB, ref int m, ref int n, ref int k, ref float alpha, ref float A, ref int ldA, ref float B, ref int ldB, ref float beta, ref float C, ref int ldC)
        {
            fixed (int* __m2 = &m)
            {
                var __arg2 = __m2;
                fixed (int* __n3 = &n)
                {
                    var __arg3 = __n3;
                    fixed (int* __k4 = &k)
                    {
                        var __arg4 = __k4;
                        fixed (float* __alpha5 = &alpha)
                        {
                            var __arg5 = __alpha5;
                            fixed (float* __A6 = &A)
                            {
                                var __arg6 = __A6;
                                fixed (int* __ldA7 = &ldA)
                                {
                                    var __arg7 = __ldA7;
                                    fixed (float* __B8 = &B)
                                    {
                                        var __arg8 = __B8;
                                        fixed (int* __ldB9 = &ldB)
                                        {
                                            var __arg9 = __ldB9;
                                            fixed (float* __beta10 = &beta)
                                            {
                                                var __arg10 = __beta10;
                                                fixed (float* __C11 = &C)
                                                {
                                                    var __arg11 = __C11;
                                                    fixed (int* __ldC12 = &ldC)
                                                    {
                                                        var __arg12 = __ldC12;
                                                        __Internal.WrapperSgemm(transA, transB, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperDgemm(string transA, string transB, ref int m, ref int n, ref int k, ref double alpha, ref double A, ref int ldA, ref double B, ref int ldB, ref double beta, ref double C, ref int ldC)
        {
            fixed (int* __m2 = &m)
            {
                var __arg2 = __m2;
                fixed (int* __n3 = &n)
                {
                    var __arg3 = __n3;
                    fixed (int* __k4 = &k)
                    {
                        var __arg4 = __k4;
                        fixed (double* __alpha5 = &alpha)
                        {
                            var __arg5 = __alpha5;
                            fixed (double* __A6 = &A)
                            {
                                var __arg6 = __A6;
                                fixed (int* __ldA7 = &ldA)
                                {
                                    var __arg7 = __ldA7;
                                    fixed (double* __B8 = &B)
                                    {
                                        var __arg8 = __B8;
                                        fixed (int* __ldB9 = &ldB)
                                        {
                                            var __arg9 = __ldB9;
                                            fixed (double* __beta10 = &beta)
                                            {
                                                var __arg10 = __beta10;
                                                fixed (double* __C11 = &C)
                                                {
                                                    var __arg11 = __C11;
                                                    fixed (int* __ldC12 = &ldC)
                                                    {
                                                        var __arg12 = __ldC12;
                                                        __Internal.WrapperDgemm(transA, transB, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperCgemm(string transA, string transB, ref int m, ref int n, ref int k, global::System.IntPtr alpha, global::System.IntPtr A, ref int ldA, global::System.IntPtr B, ref int ldB, global::System.IntPtr beta, global::System.IntPtr C, ref int ldC)
        {
            fixed (int* __m2 = &m)
            {
                var __arg2 = __m2;
                fixed (int* __n3 = &n)
                {
                    var __arg3 = __n3;
                    fixed (int* __k4 = &k)
                    {
                        var __arg4 = __k4;
                        fixed (int* __ldA7 = &ldA)
                        {
                            var __arg7 = __ldA7;
                            fixed (int* __ldB9 = &ldB)
                            {
                                var __arg9 = __ldB9;
                                fixed (int* __ldC12 = &ldC)
                                {
                                    var __arg12 = __ldC12;
                                    __Internal.WrapperCgemm(transA, transB, __arg2, __arg3, __arg4, alpha, A, __arg7, B, __arg9, beta, C, __arg12);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperZgemm(string transA, string transB, ref int m, ref int n, ref int k, global::System.IntPtr alpha, global::System.IntPtr A, ref int ldA, global::System.IntPtr B, ref int ldB, global::System.IntPtr beta, global::System.IntPtr C, ref int ldC)
        {
            fixed (int* __m2 = &m)
            {
                var __arg2 = __m2;
                fixed (int* __n3 = &n)
                {
                    var __arg3 = __n3;
                    fixed (int* __k4 = &k)
                    {
                        var __arg4 = __k4;
                        fixed (int* __ldA7 = &ldA)
                        {
                            var __arg7 = __ldA7;
                            fixed (int* __ldB9 = &ldB)
                            {
                                var __arg9 = __ldB9;
                                fixed (int* __ldC12 = &ldC)
                                {
                                    var __arg12 = __ldC12;
                                    __Internal.WrapperZgemm(transA, transB, __arg2, __arg3, __arg4, alpha, A, __arg7, B, __arg9, beta, C, __arg12);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperSsyrk(string uplo, string transA, ref int n, ref int k, ref float alpha, ref float A, ref int ldA, ref float beta, ref float C, ref int ldC)
        {
            fixed (int* __n2 = &n)
            {
                var __arg2 = __n2;
                fixed (int* __k3 = &k)
                {
                    var __arg3 = __k3;
                    fixed (float* __alpha4 = &alpha)
                    {
                        var __arg4 = __alpha4;
                        fixed (float* __A5 = &A)
                        {
                            var __arg5 = __A5;
                            fixed (int* __ldA6 = &ldA)
                            {
                                var __arg6 = __ldA6;
                                fixed (float* __beta7 = &beta)
                                {
                                    var __arg7 = __beta7;
                                    fixed (float* __C8 = &C)
                                    {
                                        var __arg8 = __C8;
                                        fixed (int* __ldC9 = &ldC)
                                        {
                                            var __arg9 = __ldC9;
                                            __Internal.WrapperSsyrk(uplo, transA, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperDsyrk(string uplo, string transA, ref int n, ref int k, ref double alpha, ref double A, ref int ldA, ref double beta, ref double C, ref int ldC)
        {
            fixed (int* __n2 = &n)
            {
                var __arg2 = __n2;
                fixed (int* __k3 = &k)
                {
                    var __arg3 = __k3;
                    fixed (double* __alpha4 = &alpha)
                    {
                        var __arg4 = __alpha4;
                        fixed (double* __A5 = &A)
                        {
                            var __arg5 = __A5;
                            fixed (int* __ldA6 = &ldA)
                            {
                                var __arg6 = __ldA6;
                                fixed (double* __beta7 = &beta)
                                {
                                    var __arg7 = __beta7;
                                    fixed (double* __C8 = &C)
                                    {
                                        var __arg8 = __C8;
                                        fixed (int* __ldC9 = &ldC)
                                        {
                                            var __arg9 = __ldC9;
                                            __Internal.WrapperDsyrk(uplo, transA, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperCherk(string uplo, string transA, ref int n, ref int k, ref float alpha, global::System.IntPtr A, ref int ldA, ref float beta, global::System.IntPtr C, ref int ldC)
        {
            fixed (int* __n2 = &n)
            {
                var __arg2 = __n2;
                fixed (int* __k3 = &k)
                {
                    var __arg3 = __k3;
                    fixed (float* __alpha4 = &alpha)
                    {
                        var __arg4 = __alpha4;
                        fixed (int* __ldA6 = &ldA)
                        {
                            var __arg6 = __ldA6;
                            fixed (float* __beta7 = &beta)
                            {
                                var __arg7 = __beta7;
                                fixed (int* __ldC9 = &ldC)
                                {
                                    var __arg9 = __ldC9;
                                    __Internal.WrapperCherk(uplo, transA, __arg2, __arg3, __arg4, A, __arg6, __arg7, C, __arg9);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void WrapperZherk(string uplo, string transA, ref int n, ref int k, ref double alpha, global::System.IntPtr A, ref int ldA, ref double beta, global::System.IntPtr C, ref int ldC)
        {
            fixed (int* __n2 = &n)
            {
                var __arg2 = __n2;
                fixed (int* __k3 = &k)
                {
                    var __arg3 = __k3;
                    fixed (double* __alpha4 = &alpha)
                    {
                        var __arg4 = __alpha4;
                        fixed (int* __ldA6 = &ldA)
                        {
                            var __arg6 = __ldA6;
                            fixed (double* __beta7 = &beta)
                            {
                                var __arg7 = __beta7;
                                fixed (int* __ldC9 = &ldC)
                                {
                                    var __arg9 = __ldC9;
                                    __Internal.WrapperZherk(uplo, transA, __arg2, __arg3, __arg4, A, __arg6, __arg7, C, __arg9);
                                }
                            }
                        }
                    }
                }
            }
        }

        //public static global::Armadillo.RandomGenerator ArmaRngCxx11Instance
        //{
        //    get
        //    {
        //        var __ptr = (global::Armadillo.RandomGenerator.__Internal*)CppSharp.SymbolResolver.ResolveSymbol("Armadillo", "?arma_rng_cxx11_instance@arma@@3Varma_rng_cxx11@1@A");
        //        return global::Armadillo.RandomGenerator.__CreateInstance(*__ptr);
        //    }

        //    set
        //    {
        //        var __ptr = (global::Armadillo.RandomGenerator.__Internal*)CppSharp.SymbolResolver.ResolveSymbol("Armadillo", "?arma_rng_cxx11_instance@arma@@3Varma_rng_cxx11@1@A");
        //        if (ReferenceEquals(value, null))
        //            throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
        //        *__ptr = *(global::Armadillo.RandomGenerator.__Internal*)value.__Instance;
        //    }
        //}
    }
}
