using System.Reflection;
using System.Security.Cryptography;

class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser sayaTubeUser = new SayaTubeUser("Review Film Avengers oleh Reimark Samuel");
        sayaTubeUser.PrintAllVideoPlaycount();
    }
}

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    // constructor SayaTubeVideo
    public SayaTubeVideo(string title, int id)
    {
        this.title = title;
        this.id = RandomNumber();
        this.playCount = 0;
    }

    // untuk generate id number 5 digit
    private int RandomNumber()
    {
        Random random = new Random();
        return random.Next(00000, 99999);
    }

    //untuk increase play count
    public void IncreasePlayCount(int playCount)
    {
        this.playCount = playCount;
        playCount++;
    }

    // mengembalikan playcount
    public int GetPlayCount()
    {
        return this.playCount;
    }

    // mengembalikan Title
    public string GetTitle()
    {
        return this.title;
    }

    // mengeprint deskripsi video
    public void PrintVideoDetails()
    {
        Console.WriteLine("ID           : " + this.id);
        Console.WriteLine("Title        : " + this.title);
        Console.WriteLine("Play Count   : " + this.playCount);
    }
}

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(int id, List<SayaTubeVideo> uploadedVideos, string username)
    {
        this.id = RandomNumber();
        this.uploadedVideos = new List<SayaTubeVideo>();
        this.username = username;
    }

    private int RandomNumber()
    {
        Random random = new Random();
        return random.Next(00000,99999);
    }

    public int GetTotalVideoPlayCount()
    {
        int jumlah = 0;
        foreach (var  video in uploadedVideos)
        {
            jumlah+= video.GetPlayCount();
        }

        return jumlah;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        this.uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("Username : " + this.username);
        for (int i = 0;i < this.uploadedVideos.Count;i++)
        {
            Console.WriteLine("Video " + i + " judul : " + uploadedVideos[i].GetTitle());
        }
    }
}