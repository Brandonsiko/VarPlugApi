namespace VarPlugApi.Model
{
    public class CareerFaculty
    {
        public int CareerId { get; set; }
        public Career Career { get; set; }

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
