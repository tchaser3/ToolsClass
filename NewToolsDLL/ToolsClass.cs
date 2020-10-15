/* Title:           Tools Class
 * Date:            12-28-17
 * Author:          Terry Holmes
 * 
 * Description:     This is the class for the tools table and stored procedures*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace NewToolsDLL
{
    public class ToolsClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        ToolsDataSet aToolsDataSet;
        ToolsDataSetTableAdapters.toolsTableAdapter aToolsTableAdapter;

        InsertToolsEntryTableAdapters.QueriesTableAdapter aInsertToolsTableAdapter;

        UpdateToolAvailabilityEntryTableAdapters.QueriesTableAdapter aUpdateToolAvailabilityTableAdapter;

        UpdateToolSignOutEntryTableAdapters.QueriesTableAdapter aUpdateToolSignOutTableAdapter;

        UpdateToolActiveEntryTableAdapters.QueriesTableAdapter aUpdateToolActiveTableAdapter;

        UpdateToolCurrentLocationEntryTableAdapters.QueriesTableAdapter aUpdateToolCurentLocationTableAdapter;

        UpdateToolCostEntryTableAdapters.QueriesTableAdapter aUpdateToolCostTableAdapter;

        UpdateToolCategoryEntryTableAdapters.QueriesTableAdapter aUpdateToolCategoryTableAdapter;

        FindActiveToolByToolIDDataSet aFindActiveToolByToolIDDataSet;
        FindActiveToolByToolIDDataSetTableAdapters.FindActiveToolByToolIDTableAdapter aFindActiveToolByToolIDTableAdapter;

        FindToolByToolIDDataSet aFindToolByToolIDDataSet;
        FindToolByToolIDDataSetTableAdapters.FindToolByToolIDTableAdapter aFindToolByToolIDTableAdapter;

        FindToolByToolKeyDataSet aFindToolByToolKeyDataSet;
        FindToolByToolKeyDataSetTableAdapters.FindToolByToolKeyTableAdapter aFindToolByToolKeyTableAdapter;

        FindToolsByEmployeeIDDataSet aFindToolsByEmployeeIDDataSet;
        FindToolsByEmployeeIDDataSetTableAdapters.FindToolsByEmployeeIDTableAdapter aFindToolsbyEmployeeIDTableAdapter;

        FindActiveToolsDataSet aFindActiveToolsDataSet;
        FindActiveToolsDataSetTableAdapters.FindActiveToolsTableAdapter aFindActiveToolsTableAdapter;

        FindActiveToolsByCategoryDataSet aFindActiveToolsByCategoryDataSet;
        FindActiveToolsByCategoryDataSetTableAdapters.FindActiveToolsByCategoryTableAdapter aFindActiveToolsByCategoryTableAdapter;

        FindRetiredToolsDataSet aFindRetiredToolsDataSet;
        FindRetiredToolsDataSetTableAdapters.FindRetiredToolsTableAdapter aFindRetiredToolsTableAdapter;

        FindAvailableActiveToolsDataSet aFindAvailableActiveToolsDataSet;
        FindAvailableActiveToolsDataSetTableAdapters.FindAvailableActiveToolsTableAdapter aFindAvailableActiveToolsTableAdapter;

        FindAvailableActiveToolsByCategoryDataSet aFindAvailableActiveToolsByCategoryDataSet;
        FindAvailableActiveToolsByCategoryDataSetTableAdapters.FindAvailableActiveToolsByCategoryTableAdapter aFindAvailableActiveToolsByCategoryTableAdapter;

        FindSignedOutToolsDataSet aFindSignedOutToolsDataSet;
        FindSignedOutToolsDataSetTableAdapters.FindSignedOutToolsTableAdapter aFindSignedOutToolsTableAdapter;

        FindSignedOutToolsByCategoryDataSet aFindSignedOutToolsByCategoryDataSet;
        FindSignedOutToolsByCategoryDataSetTableAdapters.FindSignedOutToolsByCategoryTableAdapter aFindSignedOutToolsByCategoryTableAdapter;

        FindSpecificToolByToolIDDataSet aFindSpecificToolByToolIDDataSet;
        FindSpecificToolByToolIDDataSetTableAdapters.FindSpecificToolByToolIDTableAdapter aFindSpecificToolByToolIDTableAdapter;

        UpdateToolInfoEntryTableAdapters.QueriesTableAdapter aUpdateToolInfoTableAdapter;

        FindDashboardToolsByEmployeeIDDataSet aFindDashboardToolsByEmployeeIDDataSet;
        FindDashboardToolsByEmployeeIDDataSetTableAdapters.FindDashboardToolsByEmployeeIDTableAdapter aFindDashboardToolsByEmployeeIDTableAdapter;

        FindToolsByCategoryDataSet aFindToolsByCategoryDataSet;
        FindToolsByCategoryDataSetTableAdapters.FindToolsByCategoryTableAdapter aFindToolsByCategoryTableAdapter;

        public FindToolsByCategoryDataSet FindToolsByCategory(string strCategory)
        {
            try
            {
                aFindToolsByCategoryDataSet = new FindToolsByCategoryDataSet();
                aFindToolsByCategoryTableAdapter = new FindToolsByCategoryDataSetTableAdapters.FindToolsByCategoryTableAdapter();
                aFindToolsByCategoryTableAdapter.Fill(aFindToolsByCategoryDataSet.FindToolsByCategory, strCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Tools By Category " + Ex.Message);
            }

            return aFindToolsByCategoryDataSet;
        }
        public FindDashboardToolsByEmployeeIDDataSet FindDashboardToolsByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindDashboardToolsByEmployeeIDDataSet = new FindDashboardToolsByEmployeeIDDataSet();
                aFindDashboardToolsByEmployeeIDTableAdapter = new FindDashboardToolsByEmployeeIDDataSetTableAdapters.FindDashboardToolsByEmployeeIDTableAdapter();
                aFindDashboardToolsByEmployeeIDTableAdapter.Fill(aFindDashboardToolsByEmployeeIDDataSet.FindDashboardToolsByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Dashboard Tools By Employee ID " + Ex.Message);
            }

            return aFindDashboardToolsByEmployeeIDDataSet;
        }
        public bool UpdateToolInfo(int intToolKey, string strPartNumber, string strToolDescription, int intCurrentLocation, decimal decToolCost, string strNotes)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateToolInfoTableAdapter = new UpdateToolInfoEntryTableAdapters.QueriesTableAdapter();
                aUpdateToolInfoTableAdapter.UpdateToolInfo(intToolKey, strPartNumber, strToolDescription, intCurrentLocation, decToolCost, strNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Update Tool Info " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindSpecificToolByToolIDDataSet FindSpecificToolByToolID(string strToolID)
        {
            try
            {
                aFindSpecificToolByToolIDDataSet = new FindSpecificToolByToolIDDataSet();
                aFindSpecificToolByToolIDTableAdapter = new FindSpecificToolByToolIDDataSetTableAdapters.FindSpecificToolByToolIDTableAdapter();
                aFindSpecificToolByToolIDTableAdapter.Fill(aFindSpecificToolByToolIDDataSet.FindSpecificToolByToolID, strToolID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Specific Tool By Tool ID " + Ex.Message);
            }

            return aFindSpecificToolByToolIDDataSet;
        }
        public FindSignedOutToolsByCategoryDataSet FindSignedOutToolsByCategory(string strCategory)
        {
            try
            {
                aFindSignedOutToolsByCategoryDataSet = new FindSignedOutToolsByCategoryDataSet();
                aFindSignedOutToolsByCategoryTableAdapter = new FindSignedOutToolsByCategoryDataSetTableAdapters.FindSignedOutToolsByCategoryTableAdapter();
                aFindSignedOutToolsByCategoryTableAdapter.Fill(aFindSignedOutToolsByCategoryDataSet.FindSignedOutToolsByCategory, strCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Signed Out Tools By Category " + Ex.Message);
            }

            return aFindSignedOutToolsByCategoryDataSet;
        }

        public FindSignedOutToolsDataSet FindSignedOutTools()
        {
            try
            {
                aFindSignedOutToolsDataSet = new FindSignedOutToolsDataSet();
                aFindSignedOutToolsTableAdapter = new FindSignedOutToolsDataSetTableAdapters.FindSignedOutToolsTableAdapter();
                aFindSignedOutToolsTableAdapter.Fill(aFindSignedOutToolsDataSet.FindSignedOutTools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Signed Out Tools " + Ex.Message);
            }

            return aFindSignedOutToolsDataSet;
        }
        public FindAvailableActiveToolsByCategoryDataSet FindAvailableActiveToolsByCategory(string strCategory)
        {
            try
            {
                aFindAvailableActiveToolsByCategoryDataSet = new FindAvailableActiveToolsByCategoryDataSet();
                aFindAvailableActiveToolsByCategoryTableAdapter = new FindAvailableActiveToolsByCategoryDataSetTableAdapters.FindAvailableActiveToolsByCategoryTableAdapter();
                aFindAvailableActiveToolsByCategoryTableAdapter.Fill(aFindAvailableActiveToolsByCategoryDataSet.FindAvailableActiveToolsByCategory, strCategory);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Available Active Tools By Category " + Ex.Message);
            }

            return aFindAvailableActiveToolsByCategoryDataSet;
        }
        public FindAvailableActiveToolsDataSet FindAvailableActiveTools()
        {
            try
            {
                aFindAvailableActiveToolsDataSet = new FindAvailableActiveToolsDataSet();
                aFindAvailableActiveToolsTableAdapter = new FindAvailableActiveToolsDataSetTableAdapters.FindAvailableActiveToolsTableAdapter();
                aFindAvailableActiveToolsTableAdapter.Fill(aFindAvailableActiveToolsDataSet.FindAvailableActiveTools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Available Active Tools " + Ex.Message);
            }

            return aFindAvailableActiveToolsDataSet;
        }
        public FindRetiredToolsDataSet FindRetiredTools()
        {
            try
            {
                aFindRetiredToolsDataSet = new FindRetiredToolsDataSet();
                aFindRetiredToolsTableAdapter = new FindRetiredToolsDataSetTableAdapters.FindRetiredToolsTableAdapter();
                aFindRetiredToolsTableAdapter.Fill(aFindRetiredToolsDataSet.FindRetiredTools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Retired Tools " + Ex.Message);
            }

            return aFindRetiredToolsDataSet;
        }
        public FindActiveToolsByCategoryDataSet FindActiveToolsByCategory(string strCategory)
        {
            try
            {
                aFindActiveToolsByCategoryDataSet = new FindActiveToolsByCategoryDataSet();
                aFindActiveToolsByCategoryTableAdapter = new FindActiveToolsByCategoryDataSetTableAdapters.FindActiveToolsByCategoryTableAdapter();
                aFindActiveToolsByCategoryTableAdapter.Fill(aFindActiveToolsByCategoryDataSet.FindActiveToolsByCategory, strCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Active Tools By Category " + Ex.Message);
            }

            return aFindActiveToolsByCategoryDataSet;
        }
        public FindActiveToolsDataSet FindActiveTools()
        {
            try
            {
                aFindActiveToolsDataSet = new FindActiveToolsDataSet();
                aFindActiveToolsTableAdapter = new FindActiveToolsDataSetTableAdapters.FindActiveToolsTableAdapter();
                aFindActiveToolsTableAdapter.Fill(aFindActiveToolsDataSet.FindActiveTools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Active Tools " + Ex.Message);
            }

            return aFindActiveToolsDataSet;
        }
        public FindToolsByEmployeeIDDataSet FindToolsByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindToolsByEmployeeIDDataSet = new FindToolsByEmployeeIDDataSet();
                aFindToolsbyEmployeeIDTableAdapter = new FindToolsByEmployeeIDDataSetTableAdapters.FindToolsByEmployeeIDTableAdapter();
                aFindToolsbyEmployeeIDTableAdapter.Fill(aFindToolsByEmployeeIDDataSet.FindToolsByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Tools By Employee ID " + Ex.Message);
            }

            return aFindToolsByEmployeeIDDataSet;
        }
        public FindToolByToolKeyDataSet FindAToolByToolKey(int intToolKey)
        {
            try
            {
                aFindToolByToolKeyDataSet = new FindToolByToolKeyDataSet();
                aFindToolByToolKeyTableAdapter = new FindToolByToolKeyDataSetTableAdapters.FindToolByToolKeyTableAdapter();
                aFindToolByToolKeyTableAdapter.Fill(aFindToolByToolKeyDataSet.FindToolByToolKey, intToolKey);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Tool By Tool Key " + Ex.Message);
            }

            return aFindToolByToolKeyDataSet;
        }
        public FindToolByToolIDDataSet FindAToolByToolID(string strToolID)
        {
            try
            {
                aFindToolByToolIDDataSet = new FindToolByToolIDDataSet();
                aFindToolByToolIDTableAdapter = new FindToolByToolIDDataSetTableAdapters.FindToolByToolIDTableAdapter();
                aFindToolByToolIDTableAdapter.Fill(aFindToolByToolIDDataSet.FindToolByToolID, strToolID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Tool By Tool ID " + Ex.Message);
            }

            return aFindToolByToolIDDataSet;
        }

        public FindActiveToolByToolIDDataSet FindActiveToolByToolID(string strToolID)
        {
            try
            {
                aFindActiveToolByToolIDDataSet = new FindActiveToolByToolIDDataSet();
                aFindActiveToolByToolIDTableAdapter = new FindActiveToolByToolIDDataSetTableAdapters.FindActiveToolByToolIDTableAdapter();
                aFindActiveToolByToolIDTableAdapter.Fill(aFindActiveToolByToolIDDataSet.FindActiveToolByToolID, strToolID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Find Active Tool By Tool ID " + Ex.Message);
            }

            return aFindActiveToolByToolIDDataSet;
        }
        public bool UpdateToolCategory(int intToolKey, int intCategoryID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateToolCategoryTableAdapter = new UpdateToolCategoryEntryTableAdapters.QueriesTableAdapter();
                aUpdateToolCategoryTableAdapter.UpdateToolCategory(intToolKey, intCategoryID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Class // Update Tool Category " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateToolcost(int intToolKey, decimal decToolCost)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateToolCostTableAdapter = new UpdateToolCostEntryTableAdapters.QueriesTableAdapter();
                aUpdateToolCostTableAdapter.UpdateToolCost(intToolKey, decToolCost);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Class // Update Tool Cost " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateToolCurrentLocation(int intToolKey, int intCurrentLocation)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateToolCurentLocationTableAdapter = new UpdateToolCurrentLocationEntryTableAdapters.QueriesTableAdapter();
                aUpdateToolCurentLocationTableAdapter.UpdateToolCurrentLocation(intToolKey, intCurrentLocation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Class // Update Tool Current Location " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateToolActive(int intToolKey, bool blnToolActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateToolActiveTableAdapter = new UpdateToolActiveEntryTableAdapters.QueriesTableAdapter();
                aUpdateToolActiveTableAdapter.UpdateToolActive(intToolKey, blnToolActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Class // Update Tool Active " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateToolSignOut(int intToolKey, int intEmployeeID, bool blnAvailable)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateToolSignOutTableAdapter = new UpdateToolSignOutEntryTableAdapters.QueriesTableAdapter();
                aUpdateToolSignOutTableAdapter.UpdateToolSignOut(intToolKey, intEmployeeID, blnAvailable, DateTime.Now);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Class // Update Tool Sign Out " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateToolAvailability(int intToolKey, bool blnAvailable)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateToolAvailabilityTableAdapter = new UpdateToolAvailabilityEntryTableAdapters.QueriesTableAdapter();
                aUpdateToolAvailabilityTableAdapter.UpdateToolAvailability(intToolKey, blnAvailable);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Class // Update Tool Availablity " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertTools(string strToolID, int intEmployeeID, string strPartNumber, int intCategoryID, string strToolDescription, decimal decToolCost, int intCurrentLocation)
        {
            bool blnFatalError = false;

            try
            {
                aInsertToolsTableAdapter = new InsertToolsEntryTableAdapters.QueriesTableAdapter();
                aInsertToolsTableAdapter.InsertTools(strToolID, intEmployeeID, DateTime.Now, strPartNumber, intCategoryID, strToolDescription, DateTime.Now, decToolCost, true, true, intCurrentLocation, "TOOL CREATED");
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Insert Tools " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ToolsDataSet GetToolsInfo()
        {
            try
            {
                aToolsDataSet = new ToolsDataSet();
                aToolsTableAdapter = new ToolsDataSetTableAdapters.toolsTableAdapter();
                aToolsTableAdapter.Fill(aToolsDataSet.tools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Get Tools Info " + Ex.Message);
            }

            return aToolsDataSet;
        }
        public void UpdateToolsDB(ToolsDataSet aToolsDataSet)
        {
            try
            {
                aToolsTableAdapter = new ToolsDataSetTableAdapters.toolsTableAdapter();
                aToolsTableAdapter.Update(aToolsDataSet.tools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tools Class // Update Tools DB " + Ex.Message);
            }
        }
    }
}
