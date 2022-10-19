using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Costura
{
	// Token: 0x0200000E RID: 14
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00004A89 File Offset: 0x00002A89
		private static string CultureToString(CultureInfo culture)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004A9C File Offset: 0x00002A9C
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004B0C File Offset: 0x00002B0C
		private static void CopyTo(Stream source, Stream destination)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004B40 File Offset: 0x00002B40
		private static Stream LoadStream(string fullName)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004BC4 File Offset: 0x00002BC4
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004BE4 File Offset: 0x00002BE4
		private static byte[] ReadStream(Stream stream)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004C0C File Offset: 0x00002C0C
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004CCC File Offset: 0x00002CCC
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004F44 File Offset: 0x00002F44
		public static void Attach()
		{
		}

		// Token: 0x0400002B RID: 43
		private static object nullCacheLock;

		// Token: 0x0400002C RID: 44
		private static Dictionary<string, bool> nullCache;

		// Token: 0x0400002D RID: 45
		private static Dictionary<string, string> assemblyNames;

		// Token: 0x0400002E RID: 46
		private static Dictionary<string, string> symbolNames;

		// Token: 0x0400002F RID: 47
		private static int isAttached;
	}
}
