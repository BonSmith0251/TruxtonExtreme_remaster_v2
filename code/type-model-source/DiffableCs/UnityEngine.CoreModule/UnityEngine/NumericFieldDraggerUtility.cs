namespace UnityEngine;

[MovedFrom("UnityEditor")]
[Token(Token = "0x2000163")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal class NumericFieldDraggerUtility
{
	[Token(Token = "0x40005FC")]
	private static bool s_UseYSign; //Field offset: 0x0

	[Address(RVA = "0x3068240", Offset = "0x3067640", Length = "0x3F")]
	[Token(Token = "0x60011C0")]
	public static float Acceleration(bool shiftPressed, bool altPressed) { }

	[Address(RVA = "0x3068340", Offset = "0x3067740", Length = "0xB7")]
	[Token(Token = "0x60011C2")]
	public static double CalculateFloatDragSensitivity(double value) { }

	[Address(RVA = "0x3068280", Offset = "0x3067680", Length = "0xB6")]
	[Token(Token = "0x60011C3")]
	public static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue) { }

	[Address(RVA = "0x3068400", Offset = "0x3067800", Length = "0x1D")]
	[Token(Token = "0x60011C4")]
	public static long CalculateIntDragSensitivity(long value) { }

	[Address(RVA = "0x30684B0", Offset = "0x30678B0", Length = "0x76")]
	[Token(Token = "0x60011C5")]
	public static ulong CalculateIntDragSensitivity(ulong value) { }

	[Address(RVA = "0x3068530", Offset = "0x3067930", Length = "0x7B")]
	[Token(Token = "0x60011C6")]
	public static double CalculateIntDragSensitivity(double value) { }

	[Address(RVA = "0x3068420", Offset = "0x3067820", Length = "0x82")]
	[Token(Token = "0x60011C7")]
	public static long CalculateIntDragSensitivity(long value, long minValue, long maxValue) { }

	[Address(RVA = "0x30685B0", Offset = "0x30679B0", Length = "0x109")]
	[Token(Token = "0x60011C1")]
	public static float NiceDelta(Vector2 deviceDelta, float acceleration) { }

}

