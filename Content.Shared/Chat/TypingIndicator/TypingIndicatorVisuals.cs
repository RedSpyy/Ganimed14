using Robust.Shared.Serialization;

namespace Content.Shared.Chat.TypingIndicator;

[Serializable, NetSerializable]
public enum TypingIndicatorVisuals : byte
{
    State,
    // Ganimed-Edit: chat channel the entity is typing in, used to tint the
    // typing indicator sprite per channel (issue #283).
    Channel
}

[Serializable]
public enum TypingIndicatorLayers : byte
{
    Base
}
