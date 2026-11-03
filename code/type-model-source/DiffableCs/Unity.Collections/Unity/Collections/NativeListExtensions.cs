namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200009F")]
public static class NativeListExtensions
{

	[Address(RVA = "0x88F700", Offset = "0x88EB00", Length = "0x83")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60007C9")]
	public static bool ArraysEqual(NativeArray<T> container, in NativeList<T>& other) { }

	[Address(RVA = "0x88F790", Offset = "0x88EB90", Length = "0x51")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60007CA")]
	public static bool ArraysEqual(NativeList<T> container, in NativeArray<T>& other) { }

	[Address(RVA = "0x88F5E0", Offset = "0x88E9E0", Length = "0xA9")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60007CB")]
	public static bool ArraysEqual(NativeList<T> container, in NativeList<T>& other) { }

	[Address(RVA = "0x88F690", Offset = "0x88EA90", Length = "0x62")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60007CC")]
	public static bool ArraysEqual(NativeList<T> container, in UnsafeList<T>& other) { }

	[Address(RVA = "0x88F910", Offset = "0x88ED10", Length = "0x83")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60007C7")]
	public static bool Contains(NativeList<T> list, U value) { }

	[Address(RVA = "0x88F9A0", Offset = "0x88EDA0", Length = "0x118")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x60007C8")]
	public static int IndexOf(NativeList<T> list, U value) { }

}

