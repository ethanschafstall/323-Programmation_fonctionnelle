using Gpx;



var path = @"C:\Users\po01imj\Documents\GitHub\323-Programmation_fonctionnelle\exos\rando\gpx\gemmikandersteg.gpx";
var path2 = @"C:\Users\po01imj\Documents\GitHub\323-Programmation_fonctionnelle\exos\rando\gpx\gemmikanderstegtest.gpx";

FileStream readfile = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
FileStream writefile = File.Create(path2);

using (GpxReader reader = new GpxReader(readfile))
{
    using (GpxWriter writer = new GpxWriter(writefile))
    {
        while (reader.Read())
        {
            //if (reader is object)
            //{
            //    var test = reader.Track.Segments;
            //}
            switch (reader.ObjectType)
            {

                case GpxObjectType.Metadata:
                    writer.WriteMetadata(reader.Metadata);
                    break;

                case GpxObjectType.WayPoint:
                    writer.WriteWayPoint(reader.WayPoint);
                    break;

                case GpxObjectType.Route:
                    writer.WriteRoute(reader.Route);
                    break;

                case GpxObjectType.Track:
                    var test = reader.Track.Segments[0].TrackPoints;

                    var test2 = reader.Track.Segments[0].TrackPoints
                        .Select((t, index) => new { index = index, t.Latitude, t.Longitude, t.Elevation })
                        .Where(t => t.index % 5 == 0)
                        .ToList();
                    var test3 = test2.Select(t => $"<trkpt lat=\"{t.Latitude}\" lon=\"{t.Longitude}\"><ele>{t.Elevation}</ele></trkpt>").ToList();
                    test3.Insert(0, $"<trk><name> Gemmi - Kandersteg </name><trkseg>");
                    test3.Add($"</trkseg></trk>");

                    writer.WriteTrack(reader.Track);
                    break;

            }
        }
    }
}