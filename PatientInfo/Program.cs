using System;

namespace PatientInfo
/// <summary>
/// Information on the Patient details
/// </summary>
{
   
    class Information
        
    {
        #region Properties

           public char PatientName { get; set; }
        //Name of the Patient
           public string DateOfBirth { get; set; }
        //Patient's Date of birth
           public int ContactNumber { get; set; }
        //Contact number of the Patient
           public decimal Weight { get; set; }
        //Current weight of the Patient
           public bool InsuranceAvailability{ get; set; }
        // Insurance Availabilty for the given Patient - Yes or No.

        #endregion


    }
    #region Methods
    /// <summary>
    /// Enters the Patient's name
    /// </summary>
    /// <param name="PatientName"></param> Patient's name entry
    
{
    
   
}
}