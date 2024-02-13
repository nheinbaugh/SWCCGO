namespace SWCCGO.Models;

/// <summary>
/// Describes the things about a card game, such as the name of the game, various properties and essentially teach the rest of the program how to understand that card game.
/// 
/// Ideally this is provided via some type of JSON that allows the system to process games of differing rulesets
/// </summary>
public interface ICardGameRulesMeta<TCardProperties>
{
    string GameName { get; }
    string GameFriendlyName { get; }
    TCardProperties GameCardProperties { get; }
}

public enum GameCardPropertyType
{
    DiscreteList,
    Dynamic
}

/// <summary>
/// A list of allowed values for a property (of a card) that is defined by a game
/// </summary>
public interface IGameCardProperty
{
    string Name { get; }
    string Description { get; }
    GameCardPropertyType Type { get; }
}

public interface IGameCardDiscreteProperty : IGameCardProperty
{
    GameCardPropertyType Type => GameCardPropertyType.DiscreteList;
    IEnumerable<string> AllowedValues { get; }
}

public interface IGameCardDynamicProperty : IGameCardProperty
{
    GameCardPropertyType Type => GameCardPropertyType.Dynamic;
    IEnumerable<string> AllowedValues { get; }
}

public interface ICard
{
    Guid CardId { get; }

    string CardName { get; }

    IEnumerable<ICardPropertyValue> CardPropertyValues { get; set; }
}

/// <summary>
/// Game specific concepts. 
/// </summary>
public interface ICardPropertyValue
{
    public string PropertyKey { get; }

    public string PropertyValue { get; set; }

}