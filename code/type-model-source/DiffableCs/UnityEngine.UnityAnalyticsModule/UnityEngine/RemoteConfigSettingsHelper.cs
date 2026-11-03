namespace UnityEngine;

[Token(Token = "0x2000005")]
internal static class RemoteConfigSettingsHelper
{
	[RequiredByNativeCode]
	[Token(Token = "0x2000006")]
	public enum Tag : int
	{
		kUnknown = 0,
		kIntVal = 1,
		kInt64Val = 2,
		kUInt64Val = 3,
		kDoubleVal = 4,
		kBoolVal = 5,
		kStringVal = 6,
		kArrayVal = 7,
		kMixedArrayVal = 8,
		kMapVal = 9,
		kMaxTags = 10,
	}


}

