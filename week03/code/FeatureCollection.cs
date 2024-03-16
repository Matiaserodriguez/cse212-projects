
public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; }
}

public class Feature {
    public string Type { get; set; }
    public Property Properties { get; set; }
    public Geometry Geometry { get; set; }
    public string Id {get; set;}
}

public class Property {
    public double Mag { get; set; } // : 2.23,
    public string Place { get; set; } // : "17 km SW of Toms Place, CA",
    public object Time { get; set; } // : 1710542085960,
    public object Updated { get; set; } // : 1710549372856,
    public object Tz { get; set; } // : null,
    public string Url { get; set; } // : "https://earthquake.usgs.gov/earthquakes/eventpage/nc74018046",
    public string Detail { get; set; } // : "https://earthquake.usgs.gov/earthquakes/feed/v1.0/detail/nc74018046.geojson",
    public object Felt { get; set; } // : null,
    public object Cdi { get; set; } // : null,
    public object Mmi { get; set; } // : null,
    public object Alert { get; set; } // : null,
    public string Status { get; set; } // : "automatic",
    public int? Tsunami { get; set; } // : 0,
    public int? Sig { get; set; } // : 77,
    public string Net { get; set; } // : "nc",
    public string Code { get; set; } // : "74018046",
    public string Ids { get; set; } // : ",nc74018046,nn00874840,",
    public string Sources { get; set; } // : ",nc,nn,",
    public string Types { get; set; } // : ",nearby-cities,origin,phase-data,",
    public object Nst { get; set; } // : 16,
    public double? Dmin { get; set; } // : 0.1417,
    public double? Rms { get; set; } // : 0.09,
    public object Gap { get; set; } // : 122,
    public string MagType { get; set; } // : "md",
    public string Type { get; set; } // : "earthquake",
    public string Title { get; set; } // : "M 2.2 - 17 km SW of Toms Place, CA"

}

public class Geometry {
    public string Type {get; set;}
    public double[] Coordinates {get; set;}
}