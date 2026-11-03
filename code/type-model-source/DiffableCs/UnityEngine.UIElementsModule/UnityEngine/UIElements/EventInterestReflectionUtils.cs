namespace UnityEngine.UIElements;

[Token(Token = "0x2000545")]
internal static class EventInterestReflectionUtils
{
	[Token(Token = "0x2000546")]
	private struct DefaultEventInterests
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001177")]
		public int DefaultActionCategories; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001178")]
		public int DefaultActionAtTargetCategories; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001179")]
		public int HandleEventTrickleDownCategories; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400117A")]
		public int HandleEventBubbleUpCategories; //Field offset: 0xC

	}

	[Token(Token = "0x4001175")]
	private static readonly Dictionary<Type, DefaultEventInterests> s_DefaultEventInterests; //Field offset: 0x0
	[Token(Token = "0x4001176")]
	private static readonly Dictionary<Type, EventCategory> s_EventCategories; //Field offset: 0x8

	[Address(RVA = "0x32B9BA0", Offset = "0x32B8FA0", Length = "0xE6")]
	[Token(Token = "0x60026C8")]
	private static EventInterestReflectionUtils() { }

	[Address(RVA = "0x32B9470", Offset = "0x32B8870", Length = "0x21A")]
	[Token(Token = "0x60026C6")]
	private static int ComputeDefaultEventInterests(Type elementType, string methodName) { }

	[Address(RVA = "0x32B9690", Offset = "0x32B8A90", Length = "0x2EF")]
	[Token(Token = "0x60026C5")]
	internal static void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories, out int handleEventTrickleDownCategories, out int handleEventBubbleUpCategories) { }

	[Address(RVA = "0x32B9980", Offset = "0x32B8D80", Length = "0x214")]
	[Token(Token = "0x60026C7")]
	internal static EventCategory GetEventCategory(Type eventType) { }

}

