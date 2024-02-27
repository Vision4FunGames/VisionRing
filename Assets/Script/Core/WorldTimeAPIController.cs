using System;
using System.Net.Http;
using System.Threading.Tasks;
using NaughtyAttributes;
using UnityEngine;

public class WorldTimeAPIController : MonoBehaviour
{
    private const string WorldTimeAPIURL = "http://worldtimeapi.org/api/timezone/Europe/Istanbul";
    public DateTime globalTimeLast;
    public float timeInterval;
   
    [Button("Get GlobalTime")]
    public async Task GetGlobalTime()
    {
        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(WorldTimeAPIURL);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    WorldTimeData worldTimeData = JsonUtility.FromJson<WorldTimeData>(jsonResult);


                    DateTime globalTime = DateTime.Parse(worldTimeData.datetime);
                    globalTimeLast = globalTime;
                    Debug.Log("Global Time: " + globalTime);
                }
                else
                {
                    Debug.LogError("Api Call Failed, Status Code: " + response.StatusCode);
                }
            }
            catch (Exception e)
            {
                Debug.LogError("Api Call Failed, Error: " + e.Message);
            }
        }
    }

    [Serializable]
    public class WorldTimeData
    {
        public string datetime;
        public int day_of_week;
        public int day_of_year;
    }
}
