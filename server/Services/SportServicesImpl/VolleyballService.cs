public class VolleyballService: ISportService
{
    public VolleyballService(HttpClient httpClient)
    {}

    public SportType SportType => SportType.Volleyball;

    public Task<AllSport> GetAllSport()
    {
        throw new NotImplementedException();
    }

    public Task<Game> GetGame(int gameId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Game>> GetGamesOf(int leagueId)
    {
        throw new NotImplementedException();
    }

    public Task<List<League>> GetLeagues()
    {
        throw new NotImplementedException();
    }

    public Task<LiveResult> GetLive()
    {
        throw new NotImplementedException();
    }

    public Task<Player> GetPlayersOfTeam(int teamId)
    {
        throw new NotImplementedException();
    }

    public Task<PopularEvent> GetPopularEvents()
    {
        throw new NotImplementedException();
    }
}