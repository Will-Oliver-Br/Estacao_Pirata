using Robust.Shared.Serialization;

namespace Content.Shared.Chemistry;

public sealed class SharedMedipenRefiller
{
    public const string BufferSolutionName = "buffer";
    public const string InputSlotName = "beakerSlot";
    public const string MedipenSlotName = "medipenSlot";

    [Serializable, NetSerializable]
    public enum MedipenRefillerUiKey
    {
        Key
    }

}

[Serializable, NetSerializable]
public sealed class MedipenRefillerUpdateState : BoundUserInterfaceState
{
    public List<MedipenRecipePrototype> Recipes;
    public MedipenRefillerUpdateState(List<MedipenRecipePrototype> recipes)
    {
        Recipes = recipes;
    }
}

[Serializable, NetSerializable]
public sealed class MedipenRefillerSyncRequestMessage : BoundUserInterfaceMessage
{
}