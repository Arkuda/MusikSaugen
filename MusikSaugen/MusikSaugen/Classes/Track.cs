using System;

public class Track
{
   // private string Artist;
    private string Name;
    private string ID;
    private string Link;

    public Track(string Name, string Link)
	{
	    this.Name = Name;
        //http://cs4533v4.vk.me/u11379045/audios/18857f202635.mp3?extra=HV4zO4SKu52ZY3WWTeminraRRp4KFK08rgFzG44F-sjCdPCN9E3FsvxQdzv7SNhJSuAbGulqcHAQt9b0MU6nGzeFylkxpkY,204
        string[] id = Link.Split('?');  //[0] - http://cs4533v4.vk.me/u11379045/audios/18857f202635.mp3
        id = id[0].Split('/'); //[4] - 18857f202635.mp3
        id = id[5].Split('.'); // [0] - 18857f202635
        this.ID = id[0];
	    this.Link = Link;
	}

    public string GetLink()
    {
        return this.Link;
    }


    public string GetName()
    {
        return this.Name;
    }

    public string GetID()
    {
        return this.ID;
    }
}
