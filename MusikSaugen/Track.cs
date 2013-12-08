using System;

public class Track
{
    private string Artist, Name, ID, Link;

	public Track(string Artist, string Name, string ID, string Link)
	{
	    this.Artist = Artist;
	    this.Name = Name;
	    this.ID = ID;
	    this.Link = Link;
	}

    public string GetLink()
    {
        return this.Link;
    }

    public string GetArtist()
    {
        return this.Artist;
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
