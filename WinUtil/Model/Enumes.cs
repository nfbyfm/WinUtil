namespace WinUtil.Model
{
    /// <summary>
    /// enum for file size leagues
    /// </summary>
    public enum FileSize
    {
        Bytes,
        KiloBytes,
        MegaBytes,
        GigaBytes,
        PetaBytes
    }

    /// <summary>
    /// enum describing how to sort a list of files
    /// </summary>
    public enum OrderFileListByCriteria
    {
        FileName,
        CreationDate,
        ChangeDate
    }
}
