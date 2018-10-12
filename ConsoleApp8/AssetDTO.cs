using System.Collections.Generic;

namespace ConsoleApp8
{
    public class AssetDTO
    {
        public string AssetId { get; set; }
        public string DeviceSerialNumber { get; set; }
        public string Type { get; set; }
        //public IEnumerable<GeoFence> Geofences { get; set; }
    }

    //public class GeoFence
    //{
    //    public string GeofenceId { get; set; }
    //    public string GeofenceName { get; set; }
    //    public string Description { get; set; }
    //    public string GeofenceShape { get; set; }
    //    public IEnumerable<LatLng> LatLngList { get; set; }
    //    public string Radius { get; set; }
    //    public string Zoom { get; set; }
    //    public string GeofenceType { get; set; }
    //}

    //public class LatLng
    //{
    //    public string Latitude { get; set; }
    //    public string Longitude { get; set; }
    //}
}