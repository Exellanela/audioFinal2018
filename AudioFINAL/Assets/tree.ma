//Maya ASCII 2018 scene
//Name: tree.ma
//Last modified: Wed, Nov 28, 2018 02:20:01 PM
//Codeset: UTF-8
requires maya "2018";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2018";
fileInfo "version" "2018";
fileInfo "cutIdentifier" "201706261615-f9658c4cfc";
fileInfo "osv" "Mac OS X 10.11.6";
fileInfo "license" "student";
createNode transform -s -n "persp";
	rename -uid "304134DF-3E4B-A406-5149-16AD2F165ED9";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1.1629138006715869 1.8079876949158407 -4.7864036126134692 ;
	setAttr ".r" -type "double3" -0.33835272957637191 -910.99999999989109 0 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "4AB53E83-354C-8C10-BC73-E28CCC9376A9";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999986;
	setAttr ".coi" 4.6382979646595368;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".hc" -type "string" "viewSet -p %camera";
createNode transform -s -n "top";
	rename -uid "DB84EE6B-2847-87AD-89FE-35BFF1AFED09";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 1000.1 0 ;
	setAttr ".r" -type "double3" -89.999999999999986 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "DD255095-2E47-465D-D02E-6D9B053E8932";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
createNode transform -s -n "front";
	rename -uid "D087DE3F-774C-6212-3B13-3CB753895EE9";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 1000.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "4CDD29A7-634C-8FD3-D0C8-4A9C09A18E38";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
createNode transform -s -n "side";
	rename -uid "7AC01AAA-7F47-2EBE-25CF-048C811CF813";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1000.1 0 0 ;
	setAttr ".r" -type "double3" 0 89.999999999999986 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "FE4BCB34-3446-03DB-4210-2E8851816359";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
createNode transform -n "pCylinder1";
	rename -uid "577D07D2-FB45-E356-D8B8-D9BB736B8FB3";
	setAttr ".t" -type "double3" 0.20209651431723064 1.949975683035116 -0.2948902564788014 ;
	setAttr ".s" -type "double3" 1.2103257905030298 1.0423342333120331 1.2180104778715997 ;
createNode mesh -n "pCylinderShape1" -p "pCylinder1";
	rename -uid "9F280888-AB48-654E-446B-83AD945AC178";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.52288229018449783 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 69 ".pt";
	setAttr ".pt[0]" -type "float3" 7.4505806e-09 -2.9802322e-07 -7.4505806e-09 ;
	setAttr ".pt[2]" -type "float3" 1.4901161e-08 -0.40115827 0 ;
	setAttr ".pt[3]" -type "float3" 1.4901161e-08 -0.40115827 0 ;
	setAttr ".pt[4]" -type "float3" -3.7252903e-08 -5.9604645e-08 -1.4901161e-08 ;
	setAttr ".pt[5]" -type "float3" 1.4901161e-08 -0.40115827 0 ;
	setAttr ".pt[6]" -type "float3" 1.4901161e-08 -0.40115827 0 ;
	setAttr ".pt[7]" -type "float3" 2.2351742e-08 -5.9604645e-08 -1.1641532e-10 ;
	setAttr ".pt[8]" -type "float3" 0 -0.40115827 0 ;
	setAttr ".pt[10]" -type "float3" 1.4901161e-08 -0.40115827 0 ;
	setAttr ".pt[12]" -type "float3" 1.4901161e-08 -0.40115827 0 ;
	setAttr ".pt[14]" -type "float3" 1.4901161e-08 -0.40115827 0 ;
	setAttr ".pt[16]" -type "float3" 7.4505806e-09 -2.9802322e-07 -7.4505806e-09 ;
	setAttr ".pt[17]" -type "float3" -7.4505806e-09 5.9604645e-08 2.9802322e-08 ;
	setAttr ".pt[18]" -type "float3" -2.2351742e-08 -0.40115821 -7.4505806e-09 ;
	setAttr ".pt[19]" -type "float3" -7.4505806e-09 -0.40115821 -1.1641532e-10 ;
	setAttr ".pt[20]" -type "float3" -2.2351742e-08 -0.40115821 -1.4901161e-08 ;
	setAttr ".pt[21]" -type "float3" -7.4505806e-09 5.9604645e-08 -2.9802322e-08 ;
	setAttr ".pt[22]" -type "float3" 7.4505806e-09 -0.40115821 -1.4901161e-08 ;
	setAttr ".pt[23]" -type "float3" 2.2351742e-08 5.9604645e-08 -1.1641532e-10 ;
	setAttr ".pt[24]" -type "float3" -7.4505806e-09 -0.40115827 1.4901161e-08 ;
	setAttr ".pt[25]" -type "float3" -7.4505806e-09 5.9604645e-08 0 ;
	setAttr ".pt[26]" -type "float3" -7.4505806e-09 -0.40115827 1.4901161e-08 ;
	setAttr ".pt[27]" -type "float3" -7.4505806e-09 5.9604645e-08 1.1641532e-10 ;
	setAttr ".pt[28]" -type "float3" -7.4505806e-09 -0.40115833 -1.4901161e-08 ;
	setAttr ".pt[29]" -type "float3" -7.4505806e-09 5.9604645e-08 0 ;
	setAttr ".pt[30]" -type "float3" 7.4505806e-09 -0.40115833 0 ;
	setAttr ".pt[31]" -type "float3" -7.4505806e-09 5.9604645e-08 1.1641532e-10 ;
	setAttr ".pt[32]" -type "float3" 7.4505806e-09 5.9604645e-08 -7.4505806e-09 ;
	setAttr ".pt[33]" -type "float3" -7.4505806e-09 5.9604645e-08 2.9802322e-08 ;
	setAttr ".pt[34]" -type "float3" -2.2351742e-08 -0.40115839 -7.4505806e-09 ;
	setAttr ".pt[35]" -type "float3" -3.7252903e-08 5.9604645e-08 -1.1641532e-10 ;
	setAttr ".pt[36]" -type "float3" -2.2351742e-08 -0.40115839 -1.4901161e-08 ;
	setAttr ".pt[37]" -type "float3" -7.4505806e-09 5.9604645e-08 -2.9802322e-08 ;
	setAttr ".pt[38]" -type "float3" 7.4505806e-09 5.9604645e-08 -1.4901161e-08 ;
	setAttr ".pt[39]" -type "float3" 2.2351742e-08 5.9604645e-08 -1.1641532e-10 ;
	setAttr ".pt[40]" -type "float3" -7.4505806e-09 -0.40115827 1.4901161e-08 ;
	setAttr ".pt[41]" -type "float3" -7.4505806e-09 5.9604645e-08 0 ;
	setAttr ".pt[42]" -type "float3" -7.4505806e-09 -0.40115827 1.4901161e-08 ;
	setAttr ".pt[43]" -type "float3" -7.4505806e-09 5.9604645e-08 1.1641532e-10 ;
	setAttr ".pt[44]" -type "float3" -7.4505806e-09 -0.40115827 -1.4901161e-08 ;
	setAttr ".pt[45]" -type "float3" -7.4505806e-09 5.9604645e-08 0 ;
	setAttr ".pt[46]" -type "float3" 7.4505806e-09 -0.40115827 0 ;
	setAttr ".pt[47]" -type "float3" -7.4505806e-09 5.9604645e-08 1.1641532e-10 ;
	setAttr ".pt[48]" -type "float3" 7.4505806e-09 5.9604645e-08 -7.4505806e-09 ;
	setAttr ".pt[49]" -type "float3" -7.4505806e-09 5.9604645e-08 2.9802322e-08 ;
	setAttr ".pt[50]" -type "float3" -3.7252903e-08 5.9604645e-08 -7.4505806e-09 ;
	setAttr ".pt[51]" -type "float3" -3.7252903e-08 5.9604645e-08 -1.1641532e-10 ;
	setAttr ".pt[52]" -type "float3" -3.7252903e-08 5.9604645e-08 -1.4901161e-08 ;
	setAttr ".pt[53]" -type "float3" -7.4505806e-09 5.9604645e-08 -2.9802322e-08 ;
	setAttr ".pt[54]" -type "float3" 7.4505806e-09 5.9604645e-08 -1.4901161e-08 ;
	setAttr ".pt[55]" -type "float3" 2.2351742e-08 5.9604645e-08 -1.1641532e-10 ;
	setAttr ".pt[56]" -type "float3" -7.4505806e-09 -0.40115833 1.4901161e-08 ;
	setAttr ".pt[57]" -type "float3" -7.4505806e-09 5.9604645e-08 0 ;
	setAttr ".pt[58]" -type "float3" -7.4505806e-09 -0.40115833 1.4901161e-08 ;
	setAttr ".pt[59]" -type "float3" -7.4505806e-09 5.9604645e-08 1.1641532e-10 ;
	setAttr ".pt[60]" -type "float3" -7.4505806e-09 -0.40115839 -1.4901161e-08 ;
	setAttr ".pt[61]" -type "float3" -7.4505806e-09 5.9604645e-08 0 ;
	setAttr ".pt[62]" -type "float3" 7.4505806e-09 -0.40115839 0 ;
	setAttr ".pt[63]" -type "float3" -7.4505806e-09 5.9604645e-08 1.1641532e-10 ;
	setAttr ".pt[64]" -type "float3" -2.2351742e-08 5.9604645e-08 0 ;
	setAttr ".pt[65]" -type "float3" -7.4505806e-09 5.9604645e-08 1.4901161e-08 ;
	setAttr ".pt[66]" -type "float3" -7.4505806e-09 5.9604645e-08 0 ;
	setAttr ".pt[67]" -type "float3" 7.4505806e-09 5.9604645e-08 1.1641532e-10 ;
	setAttr ".pt[68]" -type "float3" -7.4505806e-09 5.9604645e-08 -7.4505806e-09 ;
	setAttr ".pt[69]" -type "float3" -7.4505806e-09 5.9604645e-08 -1.4901161e-08 ;
	setAttr ".pt[70]" -type "float3" -2.2351742e-08 5.9604645e-08 7.4505806e-09 ;
	setAttr ".pt[71]" -type "float3" -2.2351742e-08 5.9604645e-08 1.1641532e-10 ;
	setAttr ".pt[72]" -type "float3" -7.4505806e-09 5.9604645e-08 0 ;
	setAttr ".pt[73]" -type "float3" -7.4505806e-09 5.9604645e-08 -1.1641532e-10 ;
createNode transform -n "pCylinder2";
	rename -uid "538B1529-1648-DBFE-496F-098F7816A254";
	setAttr ".t" -type "double3" 0.23095583966899502 0.84981641145570097 -0.28425881498345074 ;
createNode mesh -n "pCylinderShape2" -p "pCylinder2";
	rename -uid "4B50D776-184A-BF56-7602-2FB18D1A54D5";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "DC8DF917-1849-F26F-1B20-E596632D1FD7";
	setAttr -s 3 ".lnk";
	setAttr -s 3 ".slnk";
createNode displayLayerManager -n "layerManager";
	rename -uid "BD587C84-884D-723A-F486-2B8D2FB4D341";
createNode displayLayer -n "defaultLayer";
	rename -uid "2B9445D3-7743-2A11-7BD7-F984572151E0";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "2AE0BEB1-4C4F-9595-C1DC-81942391C4BF";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "CFEEB01B-A547-1F48-33CF-6BB606A18CFA";
	setAttr ".g" yes;
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "37FE598C-4748-EAE6-33A3-3D98052130D5";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "FF1EC968-334B-702D-0653-A69BEE61F960";
createNode polyCylinder -n "polyCylinder1";
	rename -uid "D6381692-124F-1F36-AA12-8DB9982256F2";
	setAttr ".sa" 8;
	setAttr ".sh" 8;
	setAttr ".sc" 1;
	setAttr ".cuv" 3;
createNode polySoftEdge -n "polySoftEdge1";
	rename -uid "CD63288F-D843-ED38-82D7-F7A8A39C7ED6";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[*]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0.20209651431723064 1.949975683035116 -0.2948902564788014 1;
	setAttr ".a" 0;
createNode polyTweak -n "polyTweak1";
	rename -uid "56103142-FD46-DDA3-A470-90A53AF250A7";
	setAttr ".uopa" yes;
	setAttr -s 74 ".tk[0:73]" -type "float3"  -0.30239904 -0.13358037 0.30038399
		 2.4921267e-08 -0.13358037 0.42564169 0.30239916 -0.13358037 0.30038399 0.42765683
		 -0.13358037 -0.0020151604 0.30239916 -0.13358037 -0.30441427 2.4921267e-08 -0.13358037
		 -0.429672 -0.3023991 -0.13358037 -0.30441433 -0.42765683 -0.13358037 -0.0020151604
		 -0.0067510456 -0.28060707 0.0047358731 0 -0.28060707 0.0075322473 0.0067510456 -0.28060707
		 0.0047358731 0 -0.28776774 0 0 -0.28776774 0 0 -0.28776774 0 0 -0.28776774 0 0 -0.28776774
		 0 -0.30239904 -0.066790186 0.30038399 2.4921267e-08 -0.066790186 0.42564169 0.30239916
		 -0.066790186 0.30038399 0.42765683 -0.066790186 -0.0020151604 0.30239916 -0.066790186
		 -0.30441427 2.4921267e-08 -0.066790186 -0.429672 -0.3023991 -0.066790186 -0.30441433
		 -0.42765683 -0.066790186 -0.0020151604 -0.0067510456 -0.28538069 0.0047358731 0 -0.28538069
		 0.0075322473 0.0067510456 -0.28538069 0.0047358731 0 -0.28776774 0 0 -0.28776774
		 0 0 -0.28776774 0 0 -0.28776774 0 0 -0.28776774 0 -0.30239904 0 0.30038399 2.4921267e-08
		 0 0.42564169 0.30239916 0 0.30038399 0.42765683 0 -0.0020151604 0.30239916 0 -0.30441427
		 2.4921267e-08 0 -0.429672 -0.3023991 0 -0.30441433 -0.42765683 0 -0.0020151604 -0.0067510456
		 -0.29015431 0.0047358731 0 -0.29015431 0.0075322473 0.0067510456 -0.29015431 0.0047358731
		 0 -0.28776774 0 0 -0.28776774 0 0 -0.28776774 0 0 -0.28776774 0 0 -0.28776774 0 -0.30239904
		 0.066790186 0.30038399 2.4921267e-08 0.066790186 0.42564169 0.30239916 0.066790186
		 0.30038399 0.42765683 0.066790186 -0.0020151604 0.30239916 0.066790186 -0.30441427
		 2.4921267e-08 0.066790186 -0.429672 -0.3023991 0.066790186 -0.30441433 -0.42765683
		 0.066790186 -0.0020151604 -0.0067510456 -0.29492816 0.0047358731 0 -0.29492816 0.0075322473
		 0.0067510456 -0.29492816 0.0047358731 0 -0.28776774 0 0 -0.28776774 0 0 -0.28776774
		 0 0 -0.28776774 0 0 -0.28776774 0 -0.31679589 -0.1348704 0.32690325 2.6155075e-08
		 -0.1348704 0.46314543 0.316796 -0.1348704 0.32690325 0.44801691 -0.1348704 -0.0020151576
		 0.316796 -0.1348704 -0.33093348 2.6155075e-08 -0.1348704 -0.46717578 -0.31679595
		 -0.1348704 -0.3309336 -0.44801691 -0.1348704 -0.0020151576 0 0.0095474217 -0.0020151727
		 2.1203446e-09 0.91251385 -0.0020151697;
createNode polyCylinder -n "polyCylinder2";
	rename -uid "A0F41A94-0D4E-DFBC-354E-BDB006BB4080";
	setAttr ".r" 0.2;
	setAttr ".sa" 8;
	setAttr ".sh" 8;
	setAttr ".sc" 1;
	setAttr ".cuv" 3;
createNode lambert -n "lambert2";
	rename -uid "36B981DD-794E-07E5-B9A0-A5853C70EA73";
	setAttr ".c" -type "float3" 0.2071 0.1227 0.0283 ;
createNode shadingEngine -n "lambert2SG";
	rename -uid "7C15EB9F-174B-BEBE-AFBF-5C9308BC5696";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode materialInfo -n "materialInfo1";
	rename -uid "93EDFF55-F349-5811-AF05-31AADBF8A8B9";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 3 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :lambert1;
	setAttr ".c" -type "float3" 0.083400004 0.2071 0.0284 ;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "polySoftEdge1.out" "pCylinderShape1.i";
connectAttr "polyCylinder2.out" "pCylinderShape2.i";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "polyTweak1.out" "polySoftEdge1.ip";
connectAttr "pCylinderShape1.wm" "polySoftEdge1.mp";
connectAttr "polyCylinder1.out" "polyTweak1.ip";
connectAttr "lambert2.oc" "lambert2SG.ss";
connectAttr "pCylinderShape2.iog" "lambert2SG.dsm" -na;
connectAttr "lambert2SG.msg" "materialInfo1.sg";
connectAttr "lambert2.msg" "materialInfo1.m";
connectAttr "lambert2SG.pa" ":renderPartition.st" -na;
connectAttr "lambert2.msg" ":defaultShaderList1.s" -na;
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "pCylinderShape1.iog" ":initialShadingGroup.dsm" -na;
// End of tree.ma
