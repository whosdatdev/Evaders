﻿namespace Evaders.Server.Integration
{
    using System;
    using System.Collections.Generic;
    using Core.Game;

    public interface IServerSupervisor
    {
        void GameEndedTurn(GameBase game);
        void GameEnded(GameBase game, Guid winnersIdentifiers, Guid[] loosersIdentifier);
        Guid GetBestChoice(Guid player, IEnumerable<Guid> possibleOpponents);
    }
}