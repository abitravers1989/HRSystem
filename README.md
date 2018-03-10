The problem:
--------------------------------------------------------------
We want to create an HR system that would help us calculate the Total Pension Contributions and the Total Company Contribution for an employee.

There are 3 types of employees:
*Executive*, *Manager* and *Director*

All the employees have the following basic attributes:
• Basic salary (*int*)
• Bonus (as a percentage of the basic salary) (*int*)
• Company Pension Contribution (as a percentage of the basic salary) (*int*)
• Personal Pension Contribution (as a percentage of the basic salary) (*int*)
• Health Insurance (*bool*)

*BSA*: Basic Salary
*BON*: Bonus
*CPC*: Company Pension Contribution
*PPC*: Personal Pension Contribution
*HIN*: Health Insurance

*Executive*
```-BSA: 30K
-BON: 5%
-CPC: Matching PPC up to 5% max
-PPC: (provided in the contructor, a number from 0 -> 5)
-HI : false```

*Manager*
```-BSA : 50K
-BON  : 10%
-CPC: 5%
-PPC: (provided in the constructor, a number from 0 -> 5)
-HIN : true```

*Director*
```-BSA : 75K
-BON  : 20%
-CPC: 10%
-PPC: (provided in the constructor, a number from 0 -> 5)
-HIN : true```


You'll need to provide 2 methods for each employee:

`public int GetTotalCompanyContributions()`
To be calculated as follows:
```CPC+BON+BSA+1000*HIN (when HIN = true=>1, false=>0)```

`public int GetTotalPension()`
To be calculated as follows:
```CPC+PPC```
