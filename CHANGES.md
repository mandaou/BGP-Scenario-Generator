### Sat 19 Jun 2021

* Implemented Waxman algorithm

### Fri 11 Jun 2021

* Changed allowed minimum links per node from 1 to 2
* Skipped "undeleted links" are compensated now
* Added vertical scroll to Console Screen


### Tue 08 Jun 2021

* Mesh-Type Scenario can use link damping settings
* Matlab script "netplot.m" now saves the results to ""statistics.mat
* Added console tab to show the link deletion output

### Sat 05 Jun 2021

* Added a Scenario Type: Mesh, in this type, all nodes are fully connected
* Modified MATLAB script to include more statistics (i.e. centrality types)
* NBGP config file now has an advertisement for /ASx; where x is the AS Number. Ref Node.ToNbgpConf()
* Quagga config file now has an advertisement for 10.1.x.0/24; where x is the AS Number. Ref Node.ToQuaggaConf()
* Partial implementation for Network Graph