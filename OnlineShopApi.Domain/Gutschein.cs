namespace OnlineShopApi.Domain;

public class Gutschein
{
    public long Id { get; set; }

    public string CodeName { get; set; }

    public string CodeBeschreibung { get; set; }

    public int Wert { get; set; }

    public int Wiederverwendbarkeit { get; set; }

    public int? Verwendet { get; set; }

    public byte[] Version { get; set; }

    public DateTimeOffset EinloesbarVon { get; set; }

    public DateTimeOffset EinloesbarBis { get; set; }
}
