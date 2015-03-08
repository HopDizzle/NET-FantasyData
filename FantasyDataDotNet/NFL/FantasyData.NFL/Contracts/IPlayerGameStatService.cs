﻿using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
  public interface IPlayerGameStatService
  {
    PlayerGame GetByGame(int playerId, int week, int season);
    PlayerGames GetByTeamAndWeek(TeamTypes team, int week, int season);
    PlayerGames GetByWeek(int week, int season);
  }
}
