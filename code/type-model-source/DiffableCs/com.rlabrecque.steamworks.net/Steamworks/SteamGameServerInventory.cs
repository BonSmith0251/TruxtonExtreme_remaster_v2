namespace Steamworks;

[Token(Token = "0x200000A")]
public static class SteamGameServerInventory
{

	[Address(RVA = "0x5E1120", Offset = "0x5E0520", Length = "0x5C")]
	[Token(Token = "0x6000108")]
	public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	[Address(RVA = "0x5E1180", Offset = "0x5E0580", Length = "0x74")]
	[Token(Token = "0x6000109")]
	public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	[Address(RVA = "0x5E1200", Offset = "0x5E0600", Length = "0x5B")]
	[Token(Token = "0x6000100")]
	public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	[Address(RVA = "0x5E1260", Offset = "0x5E0660", Length = "0x74")]
	[Token(Token = "0x600010A")]
	public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	[Address(RVA = "0x5E12E0", Offset = "0x5E06E0", Length = "0x86")]
	[Token(Token = "0x6000105")]
	public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, Byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false) { }

	[Address(RVA = "0x5E1370", Offset = "0x5E0770", Length = "0x4C")]
	[Token(Token = "0x6000101")]
	public static void DestroyResult(SteamInventoryResult_t resultHandle) { }

	[Address(RVA = "0x5E13C0", Offset = "0x5E07C0", Length = "0xAA")]
	[Token(Token = "0x600010B")]
	public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, UInt32[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, UInt32[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	[Address(RVA = "0x5E1470", Offset = "0x5E0870", Length = "0x85")]
	[Token(Token = "0x6000106")]
	public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

	[Address(RVA = "0x5E1500", Offset = "0x5E0900", Length = "0x4E")]
	[Token(Token = "0x6000102")]
	public static bool GetAllItems(out SteamInventoryResult_t pResultHandle) { }

	[Address(RVA = "0x5E1550", Offset = "0x5E0950", Length = "0xCC")]
	[Token(Token = "0x6000114")]
	public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	[Address(RVA = "0x5E1620", Offset = "0x5E0A20", Length = "0xB5")]
	[Token(Token = "0x6000111")]
	public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	[Address(RVA = "0x5E16E0", Offset = "0x5E0AE0", Length = "0x1C8")]
	[Token(Token = "0x6000112")]
	public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	[Address(RVA = "0x5E18B0", Offset = "0x5E0CB0", Length = "0x72")]
	[Token(Token = "0x6000119")]
	public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	[Address(RVA = "0x5E1930", Offset = "0x5E0D30", Length = "0x74")]
	[Token(Token = "0x6000103")]
	public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	[Address(RVA = "0x5E19B0", Offset = "0x5E0DB0", Length = "0x195")]
	[Token(Token = "0x6000118")]
	public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, UInt64[] pCurrentPrices, UInt64[] pBasePrices, uint unArrayLength) { }

	[Address(RVA = "0x5E1B50", Offset = "0x5E0F50", Length = "0x44")]
	[Token(Token = "0x6000117")]
	public static uint GetNumItemsWithPrices() { }

	[Address(RVA = "0x5E1BA0", Offset = "0x5E0FA0", Length = "0x1C9")]
	[Token(Token = "0x60000FE")]
	public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	[Address(RVA = "0x5E1D70", Offset = "0x5E1170", Length = "0xCA")]
	[Token(Token = "0x60000FD")]
	public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	[Address(RVA = "0x5E1E40", Offset = "0x5E1240", Length = "0x4C")]
	[Token(Token = "0x60000FC")]
	public static EResult GetResultStatus(SteamInventoryResult_t resultHandle) { }

	[Address(RVA = "0x5E1E90", Offset = "0x5E1290", Length = "0x4C")]
	[Token(Token = "0x60000FF")]
	public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle) { }

	[Address(RVA = "0x5E1EE0", Offset = "0x5E12E0", Length = "0x4E")]
	[Token(Token = "0x6000107")]
	public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle) { }

	[Address(RVA = "0x5E1F30", Offset = "0x5E1330", Length = "0x125")]
	[Token(Token = "0x6000121")]
	public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken) { }

	[Address(RVA = "0x5E2060", Offset = "0x5E1460", Length = "0x44")]
	[Token(Token = "0x6000110")]
	public static bool LoadItemDefinitions() { }

	[Address(RVA = "0x5E20B0", Offset = "0x5E14B0", Length = "0x13D")]
	[Token(Token = "0x600011B")]
	public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName) { }

	[Address(RVA = "0x5E21F0", Offset = "0x5E15F0", Length = "0x8C")]
	[Token(Token = "0x6000113")]
	public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID) { }

	[Address(RVA = "0x5E2280", Offset = "0x5E1680", Length = "0x85")]
	[Token(Token = "0x6000116")]
	public static SteamAPICall_t RequestPrices() { }

	[Address(RVA = "0x5E2310", Offset = "0x5E1710", Length = "0x44")]
	[Token(Token = "0x600010D")]
	public static void SendItemDropHeartbeat() { }

	[Address(RVA = "0x5E2360", Offset = "0x5E1760", Length = "0x72")]
	[Token(Token = "0x6000104")]
	public static bool SerializeResult(SteamInventoryResult_t resultHandle, Byte[] pOutBuffer, out uint punOutBufferSize) { }

	[Address(RVA = "0x5E23E0", Offset = "0x5E17E0", Length = "0x1CE")]
	[Token(Token = "0x600011C")]
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue) { }

	[Address(RVA = "0x5E2860", Offset = "0x5E1C60", Length = "0x14B")]
	[Token(Token = "0x600011D")]
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue) { }

	[Address(RVA = "0x5E25B0", Offset = "0x5E19B0", Length = "0x14A")]
	[Token(Token = "0x600011E")]
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue) { }

	[Address(RVA = "0x5E2700", Offset = "0x5E1B00", Length = "0x15C")]
	[Token(Token = "0x600011F")]
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue) { }

	[Address(RVA = "0x5E29B0", Offset = "0x5E1DB0", Length = "0xB1")]
	[Token(Token = "0x6000115")]
	public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

	[Address(RVA = "0x5E2A70", Offset = "0x5E1E70", Length = "0x85")]
	[Token(Token = "0x600011A")]
	public static SteamInventoryUpdateHandle_t StartUpdateProperties() { }

	[Address(RVA = "0x5E2B00", Offset = "0x5E1F00", Length = "0x5D")]
	[Token(Token = "0x6000120")]
	public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	[Address(RVA = "0x5E2B60", Offset = "0x5E1F60", Length = "0xB6")]
	[Token(Token = "0x600010F")]
	public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, UInt32[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, UInt32[] pArrayGetQuantity, uint nArrayGetLength) { }

	[Address(RVA = "0x5E2C20", Offset = "0x5E2020", Length = "0x86")]
	[Token(Token = "0x600010C")]
	public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	[Address(RVA = "0x5E2CB0", Offset = "0x5E20B0", Length = "0x5C")]
	[Token(Token = "0x600010E")]
	public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

}

