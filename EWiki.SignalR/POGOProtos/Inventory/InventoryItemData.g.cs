// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Inventory/InventoryItemData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from POGOProtos/Inventory/InventoryItemData.proto</summary>
  public static partial class InventoryItemDataReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Inventory/InventoryItemData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryItemDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlJdGVtRGF0YS5wcm90",
            "bxIUUE9HT1Byb3Rvcy5JbnZlbnRvcnkaKFBPR09Qcm90b3MvSW52ZW50b3J5",
            "L0l0ZW0vSXRlbURhdGEucHJvdG8aJ1BPR09Qcm90b3MvSW52ZW50b3J5L0Fw",
            "cGxpZWRJdGVtcy5wcm90bxooUE9HT1Byb3Rvcy9JbnZlbnRvcnkvRWdnSW5j",
            "dWJhdG9ycy5wcm90bxogUE9HT1Byb3Rvcy9JbnZlbnRvcnkvQ2FuZHkucHJv",
            "dG8aLFBPR09Qcm90b3MvSW52ZW50b3J5L0ludmVudG9yeVVwZ3JhZGVzLnBy",
            "b3RvGiZQT0dPUHJvdG9zL0ludmVudG9yeS9SYWlkVGlja2V0cy5wcm90bxon",
            "UE9HT1Byb3Rvcy9EYXRhL0F2YXRhci9BdmF0YXJJdGVtLnByb3RvGiFQT0dP",
            "UHJvdG9zL0RhdGEvUG9rZW1vbkRhdGEucHJvdG8aIlBPR09Qcm90b3MvRGF0",
            "YS9Qb2tlZGV4RW50cnkucHJvdG8aKFBPR09Qcm90b3MvRGF0YS9QbGF5ZXIv",
            "UGxheWVyU3RhdHMucHJvdG8aK1BPR09Qcm90b3MvRGF0YS9QbGF5ZXIvUGxh",
            "eWVyQ3VycmVuY3kucHJvdG8aKVBPR09Qcm90b3MvRGF0YS9QbGF5ZXIvUGxh",
            "eWVyQ2FtZXJhLnByb3RvGiJQT0dPUHJvdG9zL0RhdGEvUXVlc3RzL1F1ZXN0",
            "LnByb3RvIvIFChFJbnZlbnRvcnlJdGVtRGF0YRIyCgxwb2tlbW9uX2RhdGEY",
            "ASABKAsyHC5QT0dPUHJvdG9zLkRhdGEuUG9rZW1vbkRhdGESMQoEaXRlbRgC",
            "IAEoCzIjLlBPR09Qcm90b3MuSW52ZW50b3J5Lkl0ZW0uSXRlbURhdGESNAoN",
            "cG9rZWRleF9lbnRyeRgDIAEoCzIdLlBPR09Qcm90b3MuRGF0YS5Qb2tlZGV4",
            "RW50cnkSOQoMcGxheWVyX3N0YXRzGAQgASgLMiMuUE9HT1Byb3Rvcy5EYXRh",
            "LlBsYXllci5QbGF5ZXJTdGF0cxI/Cg9wbGF5ZXJfY3VycmVuY3kYBSABKAsy",
            "Ji5QT0dPUHJvdG9zLkRhdGEuUGxheWVyLlBsYXllckN1cnJlbmN5EjsKDXBs",
            "YXllcl9jYW1lcmEYBiABKAsyJC5QT0dPUHJvdG9zLkRhdGEuUGxheWVyLlBs",
            "YXllckNhbWVyYRJDChJpbnZlbnRvcnlfdXBncmFkZXMYByABKAsyJy5QT0dP",
            "UHJvdG9zLkludmVudG9yeS5JbnZlbnRvcnlVcGdyYWRlcxI5Cg1hcHBsaWVk",
            "X2l0ZW1zGAggASgLMiIuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuQXBwbGllZEl0",
            "ZW1zEjsKDmVnZ19pbmN1YmF0b3JzGAkgASgLMiMuUE9HT1Byb3Rvcy5JbnZl",
            "bnRvcnkuRWdnSW5jdWJhdG9ycxIqCgVjYW5keRgKIAEoCzIbLlBPR09Qcm90",
            "b3MuSW52ZW50b3J5LkNhbmR5EiwKBXF1ZXN0GAsgASgLMh0uUE9HT1Byb3Rv",
            "cy5EYXRhLlF1ZXN0cy5RdWVzdBI3CgthdmF0YXJfaXRlbRgMIAEoCzIiLlBP",
            "R09Qcm90b3MuRGF0YS5BdmF0YXIuQXZhdGFySXRlbRI3CgxyYWlkX3RpY2tl",
            "dHMYDSABKAsyIS5QT0dPUHJvdG9zLkludmVudG9yeS5SYWlkVGlja2V0c2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.Item.ItemDataReflection.Descriptor, global::POGOProtos.Inventory.AppliedItemsReflection.Descriptor, global::POGOProtos.Inventory.EggIncubatorsReflection.Descriptor, global::POGOProtos.Inventory.CandyReflection.Descriptor, global::POGOProtos.Inventory.InventoryUpgradesReflection.Descriptor, global::POGOProtos.Inventory.RaidTicketsReflection.Descriptor, global::POGOProtos.Data.Avatar.AvatarItemReflection.Descriptor, global::POGOProtos.Data.PokemonDataReflection.Descriptor, global::POGOProtos.Data.PokedexEntryReflection.Descriptor, global::POGOProtos.Data.Player.PlayerStatsReflection.Descriptor, global::POGOProtos.Data.Player.PlayerCurrencyReflection.Descriptor, global::POGOProtos.Data.Player.PlayerCameraReflection.Descriptor, global::POGOProtos.Data.Quests.QuestReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.InventoryItemData), global::POGOProtos.Inventory.InventoryItemData.Parser, new[]{ "PokemonData", "Item", "PokedexEntry", "PlayerStats", "PlayerCurrency", "PlayerCamera", "InventoryUpgrades", "AppliedItems", "EggIncubators", "Candy", "Quest", "AvatarItem", "RaidTickets" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InventoryItemData : pb::IMessage<InventoryItemData> {
    private static readonly pb::MessageParser<InventoryItemData> _parser = new pb::MessageParser<InventoryItemData>(() => new InventoryItemData());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InventoryItemData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.InventoryItemDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryItemData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryItemData(InventoryItemData other) : this() {
      PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
      Item = other.item_ != null ? other.Item.Clone() : null;
      PokedexEntry = other.pokedexEntry_ != null ? other.PokedexEntry.Clone() : null;
      PlayerStats = other.playerStats_ != null ? other.PlayerStats.Clone() : null;
      PlayerCurrency = other.playerCurrency_ != null ? other.PlayerCurrency.Clone() : null;
      PlayerCamera = other.playerCamera_ != null ? other.PlayerCamera.Clone() : null;
      InventoryUpgrades = other.inventoryUpgrades_ != null ? other.InventoryUpgrades.Clone() : null;
      AppliedItems = other.appliedItems_ != null ? other.AppliedItems.Clone() : null;
      EggIncubators = other.eggIncubators_ != null ? other.EggIncubators.Clone() : null;
      Candy = other.candy_ != null ? other.Candy.Clone() : null;
      Quest = other.quest_ != null ? other.Quest.Clone() : null;
      AvatarItem = other.avatarItem_ != null ? other.AvatarItem.Clone() : null;
      RaidTickets = other.raidTickets_ != null ? other.RaidTickets.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryItemData Clone() {
      return new InventoryItemData(this);
    }

    /// <summary>Field number for the "pokemon_data" field.</summary>
    public const int PokemonDataFieldNumber = 1;
    private global::POGOProtos.Data.PokemonData pokemonData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonData PokemonData {
      get { return pokemonData_; }
      set {
        pokemonData_ = value;
      }
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 2;
    private global::POGOProtos.Inventory.Item.ItemData item_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemData Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }

    /// <summary>Field number for the "pokedex_entry" field.</summary>
    public const int PokedexEntryFieldNumber = 3;
    private global::POGOProtos.Data.PokedexEntry pokedexEntry_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokedexEntry PokedexEntry {
      get { return pokedexEntry_; }
      set {
        pokedexEntry_ = value;
      }
    }

    /// <summary>Field number for the "player_stats" field.</summary>
    public const int PlayerStatsFieldNumber = 4;
    private global::POGOProtos.Data.Player.PlayerStats playerStats_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.PlayerStats PlayerStats {
      get { return playerStats_; }
      set {
        playerStats_ = value;
      }
    }

    /// <summary>Field number for the "player_currency" field.</summary>
    public const int PlayerCurrencyFieldNumber = 5;
    private global::POGOProtos.Data.Player.PlayerCurrency playerCurrency_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.PlayerCurrency PlayerCurrency {
      get { return playerCurrency_; }
      set {
        playerCurrency_ = value;
      }
    }

    /// <summary>Field number for the "player_camera" field.</summary>
    public const int PlayerCameraFieldNumber = 6;
    private global::POGOProtos.Data.Player.PlayerCamera playerCamera_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.PlayerCamera PlayerCamera {
      get { return playerCamera_; }
      set {
        playerCamera_ = value;
      }
    }

    /// <summary>Field number for the "inventory_upgrades" field.</summary>
    public const int InventoryUpgradesFieldNumber = 7;
    private global::POGOProtos.Inventory.InventoryUpgrades inventoryUpgrades_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.InventoryUpgrades InventoryUpgrades {
      get { return inventoryUpgrades_; }
      set {
        inventoryUpgrades_ = value;
      }
    }

    /// <summary>Field number for the "applied_items" field.</summary>
    public const int AppliedItemsFieldNumber = 8;
    private global::POGOProtos.Inventory.AppliedItems appliedItems_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.AppliedItems AppliedItems {
      get { return appliedItems_; }
      set {
        appliedItems_ = value;
      }
    }

    /// <summary>Field number for the "egg_incubators" field.</summary>
    public const int EggIncubatorsFieldNumber = 9;
    private global::POGOProtos.Inventory.EggIncubators eggIncubators_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.EggIncubators EggIncubators {
      get { return eggIncubators_; }
      set {
        eggIncubators_ = value;
      }
    }

    /// <summary>Field number for the "candy" field.</summary>
    public const int CandyFieldNumber = 10;
    private global::POGOProtos.Inventory.Candy candy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Candy Candy {
      get { return candy_; }
      set {
        candy_ = value;
      }
    }

    /// <summary>Field number for the "quest" field.</summary>
    public const int QuestFieldNumber = 11;
    private global::POGOProtos.Data.Quests.Quest quest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.Quest Quest {
      get { return quest_; }
      set {
        quest_ = value;
      }
    }

    /// <summary>Field number for the "avatar_item" field.</summary>
    public const int AvatarItemFieldNumber = 12;
    private global::POGOProtos.Data.Avatar.AvatarItem avatarItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Avatar.AvatarItem AvatarItem {
      get { return avatarItem_; }
      set {
        avatarItem_ = value;
      }
    }

    /// <summary>Field number for the "raid_tickets" field.</summary>
    public const int RaidTicketsFieldNumber = 13;
    private global::POGOProtos.Inventory.RaidTickets raidTickets_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.RaidTickets RaidTickets {
      get { return raidTickets_; }
      set {
        raidTickets_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InventoryItemData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InventoryItemData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PokemonData, other.PokemonData)) return false;
      if (!object.Equals(Item, other.Item)) return false;
      if (!object.Equals(PokedexEntry, other.PokedexEntry)) return false;
      if (!object.Equals(PlayerStats, other.PlayerStats)) return false;
      if (!object.Equals(PlayerCurrency, other.PlayerCurrency)) return false;
      if (!object.Equals(PlayerCamera, other.PlayerCamera)) return false;
      if (!object.Equals(InventoryUpgrades, other.InventoryUpgrades)) return false;
      if (!object.Equals(AppliedItems, other.AppliedItems)) return false;
      if (!object.Equals(EggIncubators, other.EggIncubators)) return false;
      if (!object.Equals(Candy, other.Candy)) return false;
      if (!object.Equals(Quest, other.Quest)) return false;
      if (!object.Equals(AvatarItem, other.AvatarItem)) return false;
      if (!object.Equals(RaidTickets, other.RaidTickets)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
      if (item_ != null) hash ^= Item.GetHashCode();
      if (pokedexEntry_ != null) hash ^= PokedexEntry.GetHashCode();
      if (playerStats_ != null) hash ^= PlayerStats.GetHashCode();
      if (playerCurrency_ != null) hash ^= PlayerCurrency.GetHashCode();
      if (playerCamera_ != null) hash ^= PlayerCamera.GetHashCode();
      if (inventoryUpgrades_ != null) hash ^= InventoryUpgrades.GetHashCode();
      if (appliedItems_ != null) hash ^= AppliedItems.GetHashCode();
      if (eggIncubators_ != null) hash ^= EggIncubators.GetHashCode();
      if (candy_ != null) hash ^= Candy.GetHashCode();
      if (quest_ != null) hash ^= Quest.GetHashCode();
      if (avatarItem_ != null) hash ^= AvatarItem.GetHashCode();
      if (raidTickets_ != null) hash ^= RaidTickets.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (pokemonData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PokemonData);
      }
      if (item_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Item);
      }
      if (pokedexEntry_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PokedexEntry);
      }
      if (playerStats_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PlayerStats);
      }
      if (playerCurrency_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PlayerCurrency);
      }
      if (playerCamera_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PlayerCamera);
      }
      if (inventoryUpgrades_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(InventoryUpgrades);
      }
      if (appliedItems_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AppliedItems);
      }
      if (eggIncubators_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(EggIncubators);
      }
      if (candy_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Candy);
      }
      if (quest_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Quest);
      }
      if (avatarItem_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AvatarItem);
      }
      if (raidTickets_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(RaidTickets);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (pokemonData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
      }
      if (item_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
      }
      if (pokedexEntry_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokedexEntry);
      }
      if (playerStats_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerStats);
      }
      if (playerCurrency_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerCurrency);
      }
      if (playerCamera_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerCamera);
      }
      if (inventoryUpgrades_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryUpgrades);
      }
      if (appliedItems_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppliedItems);
      }
      if (eggIncubators_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubators);
      }
      if (candy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Candy);
      }
      if (quest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Quest);
      }
      if (avatarItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AvatarItem);
      }
      if (raidTickets_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RaidTickets);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InventoryItemData other) {
      if (other == null) {
        return;
      }
      if (other.pokemonData_ != null) {
        if (pokemonData_ == null) {
          pokemonData_ = new global::POGOProtos.Data.PokemonData();
        }
        PokemonData.MergeFrom(other.PokemonData);
      }
      if (other.item_ != null) {
        if (item_ == null) {
          item_ = new global::POGOProtos.Inventory.Item.ItemData();
        }
        Item.MergeFrom(other.Item);
      }
      if (other.pokedexEntry_ != null) {
        if (pokedexEntry_ == null) {
          pokedexEntry_ = new global::POGOProtos.Data.PokedexEntry();
        }
        PokedexEntry.MergeFrom(other.PokedexEntry);
      }
      if (other.playerStats_ != null) {
        if (playerStats_ == null) {
          playerStats_ = new global::POGOProtos.Data.Player.PlayerStats();
        }
        PlayerStats.MergeFrom(other.PlayerStats);
      }
      if (other.playerCurrency_ != null) {
        if (playerCurrency_ == null) {
          playerCurrency_ = new global::POGOProtos.Data.Player.PlayerCurrency();
        }
        PlayerCurrency.MergeFrom(other.PlayerCurrency);
      }
      if (other.playerCamera_ != null) {
        if (playerCamera_ == null) {
          playerCamera_ = new global::POGOProtos.Data.Player.PlayerCamera();
        }
        PlayerCamera.MergeFrom(other.PlayerCamera);
      }
      if (other.inventoryUpgrades_ != null) {
        if (inventoryUpgrades_ == null) {
          inventoryUpgrades_ = new global::POGOProtos.Inventory.InventoryUpgrades();
        }
        InventoryUpgrades.MergeFrom(other.InventoryUpgrades);
      }
      if (other.appliedItems_ != null) {
        if (appliedItems_ == null) {
          appliedItems_ = new global::POGOProtos.Inventory.AppliedItems();
        }
        AppliedItems.MergeFrom(other.AppliedItems);
      }
      if (other.eggIncubators_ != null) {
        if (eggIncubators_ == null) {
          eggIncubators_ = new global::POGOProtos.Inventory.EggIncubators();
        }
        EggIncubators.MergeFrom(other.EggIncubators);
      }
      if (other.candy_ != null) {
        if (candy_ == null) {
          candy_ = new global::POGOProtos.Inventory.Candy();
        }
        Candy.MergeFrom(other.Candy);
      }
      if (other.quest_ != null) {
        if (quest_ == null) {
          quest_ = new global::POGOProtos.Data.Quests.Quest();
        }
        Quest.MergeFrom(other.Quest);
      }
      if (other.avatarItem_ != null) {
        if (avatarItem_ == null) {
          avatarItem_ = new global::POGOProtos.Data.Avatar.AvatarItem();
        }
        AvatarItem.MergeFrom(other.AvatarItem);
      }
      if (other.raidTickets_ != null) {
        if (raidTickets_ == null) {
          raidTickets_ = new global::POGOProtos.Inventory.RaidTickets();
        }
        RaidTickets.MergeFrom(other.RaidTickets);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (pokemonData_ == null) {
              pokemonData_ = new global::POGOProtos.Data.PokemonData();
            }
            input.ReadMessage(pokemonData_);
            break;
          }
          case 18: {
            if (item_ == null) {
              item_ = new global::POGOProtos.Inventory.Item.ItemData();
            }
            input.ReadMessage(item_);
            break;
          }
          case 26: {
            if (pokedexEntry_ == null) {
              pokedexEntry_ = new global::POGOProtos.Data.PokedexEntry();
            }
            input.ReadMessage(pokedexEntry_);
            break;
          }
          case 34: {
            if (playerStats_ == null) {
              playerStats_ = new global::POGOProtos.Data.Player.PlayerStats();
            }
            input.ReadMessage(playerStats_);
            break;
          }
          case 42: {
            if (playerCurrency_ == null) {
              playerCurrency_ = new global::POGOProtos.Data.Player.PlayerCurrency();
            }
            input.ReadMessage(playerCurrency_);
            break;
          }
          case 50: {
            if (playerCamera_ == null) {
              playerCamera_ = new global::POGOProtos.Data.Player.PlayerCamera();
            }
            input.ReadMessage(playerCamera_);
            break;
          }
          case 58: {
            if (inventoryUpgrades_ == null) {
              inventoryUpgrades_ = new global::POGOProtos.Inventory.InventoryUpgrades();
            }
            input.ReadMessage(inventoryUpgrades_);
            break;
          }
          case 66: {
            if (appliedItems_ == null) {
              appliedItems_ = new global::POGOProtos.Inventory.AppliedItems();
            }
            input.ReadMessage(appliedItems_);
            break;
          }
          case 74: {
            if (eggIncubators_ == null) {
              eggIncubators_ = new global::POGOProtos.Inventory.EggIncubators();
            }
            input.ReadMessage(eggIncubators_);
            break;
          }
          case 82: {
            if (candy_ == null) {
              candy_ = new global::POGOProtos.Inventory.Candy();
            }
            input.ReadMessage(candy_);
            break;
          }
          case 90: {
            if (quest_ == null) {
              quest_ = new global::POGOProtos.Data.Quests.Quest();
            }
            input.ReadMessage(quest_);
            break;
          }
          case 98: {
            if (avatarItem_ == null) {
              avatarItem_ = new global::POGOProtos.Data.Avatar.AvatarItem();
            }
            input.ReadMessage(avatarItem_);
            break;
          }
          case 106: {
            if (raidTickets_ == null) {
              raidTickets_ = new global::POGOProtos.Inventory.RaidTickets();
            }
            input.ReadMessage(raidTickets_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code