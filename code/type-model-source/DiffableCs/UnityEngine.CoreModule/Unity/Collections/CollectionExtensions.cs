namespace Unity.Collections;

[Extension]
[Token(Token = "0x200004C")]
[VisibleToOtherModules]
internal static class CollectionExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x200004D")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E4")]
		public Func<T, String> serializeElement; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000DA")]
		public <>c__DisplayClass7_0`1() { }

		[Address(RVA = "0xA75790", Offset = "0xA74B90", Length = "0x6D")]
		[Token(Token = "0x60000DB")]
		internal string <SerializedView>b__0(T t) { }

	}


	[Address(RVA = "0x79DE40", Offset = "0x79D240", Length = "0x81")]
	[Token(Token = "0x60000D6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void AddToArray(ref T[] array, T item) { }

	[Address(RVA = "0x79EAB0", Offset = "0x79DEB0", Length = "0x13D")]
	[Token(Token = "0x60000D7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void InsertIntoArray(ref T[] array, int index, T item) { }

	[Address(RVA = "0x79EE90", Offset = "0x79E290", Length = "0x144")]
	[Token(Token = "0x60000D8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
	internal static void RemoveFromArray(ref T[] array, int index) { }

	[Address(RVA = "0x79F250", Offset = "0x79E650", Length = "0x1C3")]
	[Extension]
	[Token(Token = "0x60000D9")]
	internal static string SerializedView(IEnumerable<T> collection, Func<T, String> serializeElement) { }

}

