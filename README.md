# SWCCGO

Attempting to build a more flexible game engine that can play deprecated card games online. This is a spiritual successor of GEMP, and is very likely never going tobe completed :) But it's a fun experiment.

## WTF I'm doing Right Now
* I set up an empty React app that has SignalR connected to....
* A basic ASP .NET Web API that only has a signalr hub :)
* Working on how to define the meta for a card game


### Card Game Meta
* My hope is that we can have JSON to define all the cards which are then loaded via SWCCGO.DataLoader (and a similar one for other games)
* All the models in SWCCGO.Models are jammed into a single file and I'm trying to just jam before committing to a more organized structure

### Open Questions
* Do the names make sense for `ICardGameRulesMeta<TCardProperties>` and `IGameCardDiscreteProperty`?
* The `CardGameRulesMeta` will be inherited and then used to basically drive how the game is managed... i thikn?