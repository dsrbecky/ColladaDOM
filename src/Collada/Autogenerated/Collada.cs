namespace Collada {
    
    
    /// <summary>The COLLADA element declares the root of the document that comprises some of the content 
    ///in the COLLADA schema.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class COLLADA {
        
        private Asset assetField;
        
        private object[] itemsField;
        
        private COLLADAScene sceneField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private VersionType versionField;
        
        private string baseField;
        
        /// <summary>The COLLADA element must contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("library_animation_clips", typeof(LibraryAnimationClips))]
        [System.Xml.Serialization.XmlElementAttribute("library_animations", typeof(LibraryAnimations))]
        [System.Xml.Serialization.XmlElementAttribute("library_cameras", typeof(LibraryCameras))]
        [System.Xml.Serialization.XmlElementAttribute("library_controllers", typeof(LibraryControllers))]
        [System.Xml.Serialization.XmlElementAttribute("library_effects", typeof(LibraryEffects))]
        [System.Xml.Serialization.XmlElementAttribute("library_force_fields", typeof(LibraryForceFields))]
        [System.Xml.Serialization.XmlElementAttribute("library_geometries", typeof(LibraryGeometries))]
        [System.Xml.Serialization.XmlElementAttribute("library_images", typeof(LibraryImages))]
        [System.Xml.Serialization.XmlElementAttribute("library_lights", typeof(LibraryLights))]
        [System.Xml.Serialization.XmlElementAttribute("library_materials", typeof(LibraryMaterials))]
        [System.Xml.Serialization.XmlElementAttribute("library_nodes", typeof(LibraryNodes))]
        [System.Xml.Serialization.XmlElementAttribute("library_physics_materials", typeof(LibraryPhysicsMaterials))]
        [System.Xml.Serialization.XmlElementAttribute("library_physics_models", typeof(LibraryPhysicsModels))]
        [System.Xml.Serialization.XmlElementAttribute("library_physics_scenes", typeof(LibraryPhysicsScenes))]
        [System.Xml.Serialization.XmlElementAttribute("library_visual_scenes", typeof(LibraryVisualScenes))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The scene embodies the entire set of information that can be visualized from the 
        ///contents of a COLLADA resource. The scene element declares the base of the scene 
        ///hierarchy or scene graph. The scene contains elements that comprise much of the 
        ///visual and transformational information content as created by the authoring tools.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("scene")]
        public COLLADAScene Scene {
            get {
                return this.sceneField;
            }
            set {
                this.sceneField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The version attribute is the COLLADA schema revision with which the instance document 
        ///conforms. Required Attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("version")]
        public VersionType Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("base", Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string Base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }
    }
    
    /// <summary>The asset element defines asset management information regarding its parent element.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Asset {
        
        private System.Collections.Generic.List<AssetContributor> contributorField;
        
        private System.DateTime createdField;
        
        private string keywordsField;
        
        private System.DateTime modifiedField;
        
        private string revisionField;
        
        private string subjectField;
        
        private string titleField;
        
        private AssetUnit unitField;
        
        private UpAxisType up_axisField;
        
        public Asset() {
            this.up_axisField = UpAxisType.Y_UP;
        }
        
        /// <summary>The contributor element defines authoring information for asset management
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("contributor")]
        public System.Collections.Generic.List<AssetContributor> Contributor {
            get {
                if ((this.contributorField == null)) {
                    this.contributorField = new System.Collections.Generic.List<AssetContributor>();
                }
                return this.contributorField;
            }
            set {
                this.contributorField = value;
            }
        }
        
        /// <summary>The created element contains the date and time that the parent element was created and is 
        ///represented in an ISO 8601 format.  The created element may appear zero or one time.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("created")]
        public System.DateTime Created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }
        
        /// <summary>The keywords element contains a list of words used as search criteria for the parent element. 
        ///The keywords element may appear zero or more times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("keywords")]
        public string Keywords {
            get {
                return this.keywordsField;
            }
            set {
                this.keywordsField = value;
            }
        }
        
        /// <summary>The modified element contains the date and time that the parent element was last modified and 
        ///represented in an ISO 8601 format. The modified element may appear zero or one time.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("modified")]
        public System.DateTime Modified {
            get {
                return this.modifiedField;
            }
            set {
                this.modifiedField = value;
            }
        }
        
        /// <summary>The revision element contains the revision information for the parent element. The revision 
        ///element may appear zero or one time.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("revision")]
        public string Revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
            }
        }
        
        /// <summary>The subject element contains a description of the topical subject of the parent element. The 
        ///subject element may appear zero or one time.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("subject")]
        public string Subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <summary>The title element contains the title information for the parent element. The title element may 
        ///appear zero or one time.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <summary>The unit element contains descriptive information about unit of measure. It has attributes for 
        ///the name of the unit and the measurement with respect to the meter. The unit element may appear 
        ///zero or one time.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("unit")]
        public AssetUnit Unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
        
        /// <summary>The up_axis element contains descriptive information about coordinate system of the geometric 
        ///data. All coordinates are right-handed by definition. This element specifies which axis is 
        ///considered up. The default is the Y-axis. The up_axis element may appear zero or one time.
        ///</summary>
        [System.ComponentModel.DefaultValueAttribute(UpAxisType.Y_UP)]
        public UpAxisType up_axis {
            get {
                return this.up_axisField;
            }
            set {
                this.up_axisField = value;
            }
        }
    }
    
    /// <summary>The contributor element defines authoring information for asset management
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class AssetContributor {
        
        private string authorField;
        
        private string authoring_toolField;
        
        private string commentsField;
        
        private string copyrightField;
        
        private string source_dataField;
        
        /// <summary>The author element contains a string with the author's name.
        ///There may be only one author element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("author")]
        public string Author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        /// <summary>The authoring_tool element contains a string with the authoring tool's name.
        ///There may be only one authoring_tool element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("authoring_tool")]
        public string AuthoringTool {
            get {
                return this.authoring_toolField;
            }
            set {
                this.authoring_toolField = value;
            }
        }
        
        /// <summary>The comments element contains a string with comments from this contributor.
        ///There may be only one comments element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("comments")]
        public string Comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }
        
        /// <summary>The copyright element contains a string with copyright information.
        ///There may be only one copyright element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("copyright")]
        public string Copyright {
            get {
                return this.copyrightField;
            }
            set {
                this.copyrightField = value;
            }
        }
        
        /// <summary>The source_data element contains a URI reference to the source data used for this asset.
        ///There may be only one source_data element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("source_data", DataType="anyURI")]
        public string SourceData {
            get {
                return this.source_dataField;
            }
            set {
                this.source_dataField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    [System.Xml.Serialization.XmlRootAttribute("scale", Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class TargetableFloat3 {
        
        private string sidField;
        
        private string textField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSurfaceInitFromCommon {
        
        private uint mipField;
        
        private uint sliceField;
        
        private fx_surface_face_enum faceField;
        
        private string valueField;
        
        public FxSurfaceInitFromCommon() {
            this.mipField = ((uint)(0));
            this.sliceField = ((uint)(0));
            this.faceField = fx_surface_face_enum.POSITIVE_X;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("mip")]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Mip {
            get {
                return this.mipField;
            }
            set {
                this.mipField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("slice")]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Slice {
            get {
                return this.sliceField;
            }
            set {
                this.sliceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("face")]
        [System.ComponentModel.DefaultValueAttribute(fx_surface_face_enum.POSITIVE_X)]
        public fx_surface_face_enum Face {
            get {
                return this.faceField;
            }
            set {
                this.faceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="IDREF")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_surface_face_enum {
        
        POSITIVE_X,
        
        NEGATIVE_X,
        
        POSITIVE_Y,
        
        NEGATIVE_Y,
        
        POSITIVE_Z,
        
        NEGATIVE_Z,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class CommonNewparamType {
        
        private string semanticField;
        
        private object itemField;
        
        private ItemChoiceType itemElementNameField;
        
        private string sidField;
        
        [System.Xml.Serialization.XmlElementAttribute("semantic", DataType="NCName")]
        public string Semantic {
            get {
                return this.semanticField;
            }
            set {
                this.semanticField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("float2", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("float3", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("float4", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("sampler2D", typeof(FxSampler2DCommon))]
        [System.Xml.Serialization.XmlElementAttribute("surface", typeof(FxSurfaceCommon))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSampler2DCommon {
        
        private string sourceField;
        
        private fx_sampler_wrap_common wrap_sField;
        
        private fx_sampler_wrap_common wrap_tField;
        
        private fx_sampler_filter_common minfilterField;
        
        private fx_sampler_filter_common magfilterField;
        
        private fx_sampler_filter_common mipfilterField;
        
        private string border_colorField;
        
        private byte mipmap_maxlevelField;
        
        private float mipmap_biasField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        public FxSampler2DCommon() {
            this.wrap_sField = fx_sampler_wrap_common.WRAP;
            this.wrap_tField = fx_sampler_wrap_common.WRAP;
            this.minfilterField = fx_sampler_filter_common.NONE;
            this.magfilterField = fx_sampler_filter_common.NONE;
            this.mipfilterField = fx_sampler_filter_common.NONE;
            this.mipmap_maxlevelField = ((byte)(255));
            this.mipmap_biasField = ((float)(0F));
        }
        
        [System.Xml.Serialization.XmlElementAttribute("source", DataType="NCName")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_s {
            get {
                return this.wrap_sField;
            }
            set {
                this.wrap_sField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_t {
            get {
                return this.wrap_tField;
            }
            set {
                this.wrap_tField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common minfilter {
            get {
                return this.minfilterField;
            }
            set {
                this.minfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common magfilter {
            get {
                return this.magfilterField;
            }
            set {
                this.magfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common mipfilter {
            get {
                return this.mipfilterField;
            }
            set {
                this.mipfilterField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("border_color")]
        public string BorderColor {
            get {
                return this.border_colorField;
            }
            set {
                this.border_colorField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "255")]
        public byte mipmap_maxlevel {
            get {
                return this.mipmap_maxlevelField;
            }
            set {
                this.mipmap_maxlevelField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float mipmap_bias {
            get {
                return this.mipmap_biasField;
            }
            set {
                this.mipmap_biasField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_sampler_wrap_common {
        
        NONE,
        
        WRAP,
        
        MIRROR,
        
        CLAMP,
        
        BORDER,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_sampler_filter_common {
        
        NONE,
        
        NEAREST,
        
        LINEAR,
        
        NEAREST_MIPMAP_NEAREST,
        
        LINEAR_MIPMAP_NEAREST,
        
        NEAREST_MIPMAP_LINEAR,
        
        LINEAR_MIPMAP_LINEAR,
    }
    
    /// <summary>The extra element declares additional information regarding its parent element.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Extra {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private string idField;
        
        private string nameField;
        
        private string typeField;
        
        public static System.Collections.Generic.Dictionary<string, Extra> IDs = new System.Collections.Generic.Dictionary<string, Extra>();
        
        /// <summary>The extra element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>This element must contain at least one non-common profile technique.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The type attribute indicates the type of the value data. This text string must be understood by 
        ///the application. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("type", DataType="NMTOKEN")]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <summary>The technique element declares the information used to process some portion of the content. Each 
    ///technique conforms to an associated profile. Techniques generally act as a “switch”. If more than 
    ///one is present for a particular portion of content, on import, one or the other is picked, but 
    ///usually not both. Selection should be based on which profile the importing application can support.
    ///Techniques contain application data and programs, making them assets that can be managed as a unit.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Technique {
        
        private System.Collections.Generic.List<System.Xml.XmlElement> anyField;
        
        private string profileField;
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Collections.Generic.List<System.Xml.XmlElement> Any {
            get {
                if ((this.anyField == null)) {
                    this.anyField = new System.Collections.Generic.List<System.Xml.XmlElement>();
                }
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <summary>The profile attribute indicates the type of profile. This is a vendor defined character 
        ///string that indicates the platform or capability target for the technique. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("profile", DataType="NMTOKEN")]
        public string Profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSurfaceCommon {
        
        private object init_as_nullField;
        
        private object init_as_targetField;
        
        private FxSurfaceInitCubeCommon init_cubeField;
        
        private FxSurfaceInitVolumeCommon init_volumeField;
        
        private FxSurfaceInitPlanarCommon init_planarField;
        
        private System.Collections.Generic.List<FxSurfaceInitFromCommon> init_fromField;
        
        private string formatField;
        
        private FxSurfaceFormatHintCommon format_hintField;
        
        private object itemField;
        
        private uint mip_levelsField;
        
        private bool mipmap_generateField;
        
        private bool mipmap_generateFieldSpecified;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private fx_surface_type_enum typeField;
        
        public FxSurfaceCommon() {
            this.mip_levelsField = ((uint)(0));
        }
        
        [System.Xml.Serialization.XmlElementAttribute("init_as_null")]
        public object InitAsNull {
            get {
                return this.init_as_nullField;
            }
            set {
                this.init_as_nullField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("init_as_target")]
        public object InitAsTarget {
            get {
                return this.init_as_targetField;
            }
            set {
                this.init_as_targetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("init_cube")]
        public FxSurfaceInitCubeCommon InitCube {
            get {
                return this.init_cubeField;
            }
            set {
                this.init_cubeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("init_volume")]
        public FxSurfaceInitVolumeCommon InitVolume {
            get {
                return this.init_volumeField;
            }
            set {
                this.init_volumeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("init_planar")]
        public FxSurfaceInitPlanarCommon InitPlanar {
            get {
                return this.init_planarField;
            }
            set {
                this.init_planarField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("init_from")]
        public System.Collections.Generic.List<FxSurfaceInitFromCommon> InitFrom {
            get {
                if ((this.init_fromField == null)) {
                    this.init_fromField = new System.Collections.Generic.List<FxSurfaceInitFromCommon>();
                }
                return this.init_fromField;
            }
            set {
                this.init_fromField = value;
            }
        }
        
        /// <summary>Contains a string representing the profile and platform specific texel format that the author would like this surface to use.  If this element is not specified then the application will use a common format R8G8B8A8 with linear color gradient, not  sRGB.</summary>
        [System.Xml.Serialization.XmlElementAttribute("format", DataType="token")]
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <summary>If the exact format cannot be resolved via the "format" element then the format_hint will describe the important features of the format so that the application may select a compatable or close format</summary>
        [System.Xml.Serialization.XmlElementAttribute("format_hint")]
        public FxSurfaceFormatHintCommon FormatHint {
            get {
                return this.format_hintField;
            }
            set {
                this.format_hintField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("size", typeof(long))]
        [System.Xml.Serialization.XmlElementAttribute("viewport_ratio", typeof(double))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <summary>the surface should contain the following number of MIP levels.  If this element is not present it is assumed that all miplevels exist until a dimension becomes 1 texel.  To create a surface that has only one level of mip maps (mip=0) set this to 1.  If the value is 0 the result is the same as if mip_levels was unspecified, all possible mip_levels will exist.</summary>
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint mip_levels {
            get {
                return this.mip_levelsField;
            }
            set {
                this.mip_levelsField = value;
            }
        }
        
        /// <summary>By default it is assumed that mipmaps are supplied by the author so, if not all subsurfaces are initialized, it is invalid and will result in profile and platform specific behavior unless mipmap_generate is responsible for initializing the remainder of the sub-surfaces</summary>
        [System.Xml.Serialization.XmlElementAttribute("mipmap_generate")]
        public bool MipmapGenerate {
            get {
                return this.mipmap_generateField;
            }
            set {
                this.mipmap_generateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mipmap_generateSpecified {
            get {
                return this.mipmap_generateFieldSpecified;
            }
            set {
                this.mipmap_generateFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>Specifying the type of a surface is mandatory though the type may be "UNTYPED".  When a surface is typed as UNTYPED, it is said to be temporarily untyped and instead will be typed later by the context it is used in such as which samplers reference it in that are used in a particular technique or pass.   If there is a type mismatch between what is set into it later and what the runtime decides the type should be the result in profile and platform specific behavior.</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public fx_surface_type_enum Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSurfaceInitCubeCommon {
        
        private object[] itemsField;
        
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(FxSurfaceInitCubeCommonAll))]
        [System.Xml.Serialization.XmlElementAttribute("face", typeof(FxSurfaceInitCubeCommonFace))]
        [System.Xml.Serialization.XmlElementAttribute("primary", typeof(FxSurfaceInitCubeCommonPrimary))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <summary>Init the entire surface with one compound image such as DDS</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FxSurfaceInitCubeCommonAll {
        
        private string refField;
        
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="IDREF")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    /// <summary>Init each face mipchain with one compound image such as DDS</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FxSurfaceInitCubeCommonFace {
        
        private string refField;
        
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="IDREF")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    /// <summary>Init all primary mip level 0 subsurfaces with one compound image such as DDS.  Use of this element expects that the surface has element mip_levels=0 or mipmap_generate.</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FxSurfaceInitCubeCommonPrimary {
        
        private System.Collections.Generic.List<fx_surface_face_enum> orderField;
        
        private string refField;
        
        /// <summary>If the image dues not natively describe the face ordering then this series of order elements will describe which face the index belongs too</summary>
        [System.Xml.Serialization.XmlElementAttribute("order")]
        public System.Collections.Generic.List<fx_surface_face_enum> Order {
            get {
                if ((this.orderField == null)) {
                    this.orderField = new System.Collections.Generic.List<fx_surface_face_enum>();
                }
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="IDREF")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSurfaceInitVolumeCommon {
        
        private object itemField;
        
        [System.Xml.Serialization.XmlElementAttribute("all", typeof(FxSurfaceInitVolumeCommonAll))]
        [System.Xml.Serialization.XmlElementAttribute("primary", typeof(FxSurfaceInitVolumeCommonPrimary))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <summary>Init the entire surface with one compound image such as DDS</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FxSurfaceInitVolumeCommonAll {
        
        private string refField;
        
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="IDREF")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    /// <summary>Init mip level 0 of the surface with one compound image such as DDS.  Use of this element expects that the surface has element mip_levels=0 or mipmap_generate.</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FxSurfaceInitVolumeCommonPrimary {
        
        private string refField;
        
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="IDREF")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSurfaceInitPlanarCommon {
        
        private FxSurfaceInitPlanarCommonAll itemField;
        
        [System.Xml.Serialization.XmlElementAttribute("all")]
        public FxSurfaceInitPlanarCommonAll Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <summary>Init the entire surface with one compound image such as DDS</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FxSurfaceInitPlanarCommonAll {
        
        private string refField;
        
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="IDREF")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSurfaceFormatHintCommon {
        
        private fx_surface_format_hint_channels_enum channelsField;
        
        private fx_surface_format_hint_range_enum rangeField;
        
        private fx_surface_format_hint_precision_enum precisionField;
        
        private bool precisionFieldSpecified;
        
        private System.Collections.Generic.List<fx_surface_format_hint_option_enum> optionField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>The per-texel layout of the format.  The length of the string indicate how many channels there are and the letter respresents the name of the channel.  There are typically 0 to 4 channels.</summary>
        [System.Xml.Serialization.XmlElementAttribute("channels")]
        public fx_surface_format_hint_channels_enum Channels {
            get {
                return this.channelsField;
            }
            set {
                this.channelsField = value;
            }
        }
        
        /// <summary>Each channel represents a range of values. Some example ranges are signed or unsigned integers, or between between a clamped range such as 0.0f to 1.0f, or high dynamic range via floating point</summary>
        [System.Xml.Serialization.XmlElementAttribute("range")]
        public fx_surface_format_hint_range_enum Range {
            get {
                return this.rangeField;
            }
            set {
                this.rangeField = value;
            }
        }
        
        /// <summary>Each channel of the texel has a precision.  Typically these are all linked together.  An exact format lay lower the precision of an individual channel but applying a higher precision by linking the channels together may still convey the same information.</summary>
        [System.Xml.Serialization.XmlElementAttribute("precision")]
        public fx_surface_format_hint_precision_enum Precision {
            get {
                return this.precisionField;
            }
            set {
                this.precisionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool precisionSpecified {
            get {
                return this.precisionFieldSpecified;
            }
            set {
                this.precisionFieldSpecified = value;
            }
        }
        
        /// <summary>Additional hints about data relationships and other things to help the application pick the best format.</summary>
        [System.Xml.Serialization.XmlElementAttribute("option")]
        public System.Collections.Generic.List<fx_surface_format_hint_option_enum> Option {
            get {
                if ((this.optionField == null)) {
                    this.optionField = new System.Collections.Generic.List<fx_surface_format_hint_option_enum>();
                }
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_surface_format_hint_channels_enum {
        
        RGB,
        
        RGBA,
        
        L,
        
        LA,
        
        D,
        
        XYZ,
        
        XYZW,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_surface_format_hint_range_enum {
        
        SNORM,
        
        UNORM,
        
        SINT,
        
        UINT,
        
        FLOAT,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_surface_format_hint_precision_enum {
        
        LOW,
        
        MID,
        
        HIGH,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_surface_format_hint_option_enum {
        
        SRGB_GAMMA,
        
        NORMALIZED3,
        
        NORMALIZED4,
        
        COMPRESSABLE,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_surface_type_enum {
        
        UNTYPED,
        
        [System.Xml.Serialization.XmlEnumAttribute("1D")]
        Item1D,
        
        [System.Xml.Serialization.XmlEnumAttribute("2D")]
        Item2D,
        
        [System.Xml.Serialization.XmlEnumAttribute("3D")]
        Item3D,
        
        RECT,
        
        CUBE,
        
        DEPTH,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        @float,
        
        float2,
        
        float3,
        
        float4,
        
        sampler2D,
        
        surface,
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommonTransparentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class CommonColorOrTextureType {
        
        private object itemField;
        
        [System.Xml.Serialization.XmlElementAttribute("color", typeof(CommonColorOrTextureTypeColor))]
        [System.Xml.Serialization.XmlElementAttribute("param", typeof(CommonColorOrTextureTypeParam))]
        [System.Xml.Serialization.XmlElementAttribute("texture", typeof(CommonColorOrTextureTypeTexture))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CommonColorOrTextureTypeColor {
        
        private string sidField;
        
        private string textField;
        
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CommonColorOrTextureTypeParam {
        
        private string refField;
        
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="NCName")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CommonColorOrTextureTypeTexture {
        
        private Extra extraField;
        
        private string textureField;
        
        private string texcoordField;
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public Extra Extra {
            get {
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("texture", DataType="NCName")]
        public string Texture {
            get {
                return this.textureField;
            }
            set {
                this.textureField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("texcoord", DataType="NCName")]
        public string Texcoord {
            get {
                return this.texcoordField;
            }
            set {
                this.texcoordField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class CommonTransparentType : CommonColorOrTextureType {
        
        private fx_opaque_enum opaqueField;
        
        public CommonTransparentType() {
            this.opaqueField = fx_opaque_enum.A_ONE;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("opaque")]
        [System.ComponentModel.DefaultValueAttribute(fx_opaque_enum.A_ONE)]
        public fx_opaque_enum Opaque {
            get {
                return this.opaqueField;
            }
            set {
                this.opaqueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_opaque_enum {
        
        A_ONE,
        
        RGB_ZERO,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class CommonFloatOrParamType {
        
        private object itemField;
        
        [System.Xml.Serialization.XmlElementAttribute("float", typeof(CommonFloatOrParamTypeFloat))]
        [System.Xml.Serialization.XmlElementAttribute("param", typeof(CommonFloatOrParamTypeParam))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CommonFloatOrParamTypeFloat {
        
        private string sidField;
        
        private double valueField;
        
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CommonFloatOrParamTypeParam {
        
        private string refField;
        
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="NCName")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxIncludeCommon {
        
        private string sidField;
        
        private string urlField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The url attribute refers to resource.  This may refer to a local resource using a relative URL 
        ///fragment identifier that begins with the “#” character. The url attribute may refer to an external 
        ///resource using an absolute or relative URL.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("url", DataType="anyURI")]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSamplerDEPTHCommon {
        
        private string sourceField;
        
        private fx_sampler_wrap_common wrap_sField;
        
        private fx_sampler_wrap_common wrap_tField;
        
        private fx_sampler_filter_common minfilterField;
        
        private fx_sampler_filter_common magfilterField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        public FxSamplerDEPTHCommon() {
            this.wrap_sField = fx_sampler_wrap_common.WRAP;
            this.wrap_tField = fx_sampler_wrap_common.WRAP;
            this.minfilterField = fx_sampler_filter_common.NONE;
            this.magfilterField = fx_sampler_filter_common.NONE;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("source", DataType="NCName")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_s {
            get {
                return this.wrap_sField;
            }
            set {
                this.wrap_sField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_t {
            get {
                return this.wrap_tField;
            }
            set {
                this.wrap_tField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common minfilter {
            get {
                return this.minfilterField;
            }
            set {
                this.minfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common magfilter {
            get {
                return this.magfilterField;
            }
            set {
                this.magfilterField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSamplerRECTCommon {
        
        private string sourceField;
        
        private fx_sampler_wrap_common wrap_sField;
        
        private fx_sampler_wrap_common wrap_tField;
        
        private fx_sampler_filter_common minfilterField;
        
        private fx_sampler_filter_common magfilterField;
        
        private fx_sampler_filter_common mipfilterField;
        
        private string border_colorField;
        
        private byte mipmap_maxlevelField;
        
        private float mipmap_biasField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        public FxSamplerRECTCommon() {
            this.wrap_sField = fx_sampler_wrap_common.WRAP;
            this.wrap_tField = fx_sampler_wrap_common.WRAP;
            this.minfilterField = fx_sampler_filter_common.NONE;
            this.magfilterField = fx_sampler_filter_common.NONE;
            this.mipfilterField = fx_sampler_filter_common.NONE;
            this.mipmap_maxlevelField = ((byte)(255));
            this.mipmap_biasField = ((float)(0F));
        }
        
        [System.Xml.Serialization.XmlElementAttribute("source", DataType="NCName")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_s {
            get {
                return this.wrap_sField;
            }
            set {
                this.wrap_sField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_t {
            get {
                return this.wrap_tField;
            }
            set {
                this.wrap_tField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common minfilter {
            get {
                return this.minfilterField;
            }
            set {
                this.minfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common magfilter {
            get {
                return this.magfilterField;
            }
            set {
                this.magfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common mipfilter {
            get {
                return this.mipfilterField;
            }
            set {
                this.mipfilterField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("border_color")]
        public string BorderColor {
            get {
                return this.border_colorField;
            }
            set {
                this.border_colorField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "255")]
        public byte mipmap_maxlevel {
            get {
                return this.mipmap_maxlevelField;
            }
            set {
                this.mipmap_maxlevelField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float mipmap_bias {
            get {
                return this.mipmap_biasField;
            }
            set {
                this.mipmap_biasField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSamplerCUBECommon {
        
        private string sourceField;
        
        private fx_sampler_wrap_common wrap_sField;
        
        private fx_sampler_wrap_common wrap_tField;
        
        private fx_sampler_wrap_common wrap_pField;
        
        private fx_sampler_filter_common minfilterField;
        
        private fx_sampler_filter_common magfilterField;
        
        private fx_sampler_filter_common mipfilterField;
        
        private string border_colorField;
        
        private byte mipmap_maxlevelField;
        
        private float mipmap_biasField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        public FxSamplerCUBECommon() {
            this.wrap_sField = fx_sampler_wrap_common.WRAP;
            this.wrap_tField = fx_sampler_wrap_common.WRAP;
            this.wrap_pField = fx_sampler_wrap_common.WRAP;
            this.minfilterField = fx_sampler_filter_common.NONE;
            this.magfilterField = fx_sampler_filter_common.NONE;
            this.mipfilterField = fx_sampler_filter_common.NONE;
            this.mipmap_maxlevelField = ((byte)(255));
            this.mipmap_biasField = ((float)(0F));
        }
        
        [System.Xml.Serialization.XmlElementAttribute("source", DataType="NCName")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_s {
            get {
                return this.wrap_sField;
            }
            set {
                this.wrap_sField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_t {
            get {
                return this.wrap_tField;
            }
            set {
                this.wrap_tField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_p {
            get {
                return this.wrap_pField;
            }
            set {
                this.wrap_pField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common minfilter {
            get {
                return this.minfilterField;
            }
            set {
                this.minfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common magfilter {
            get {
                return this.magfilterField;
            }
            set {
                this.magfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common mipfilter {
            get {
                return this.mipfilterField;
            }
            set {
                this.mipfilterField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("border_color")]
        public string BorderColor {
            get {
                return this.border_colorField;
            }
            set {
                this.border_colorField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "255")]
        public byte mipmap_maxlevel {
            get {
                return this.mipmap_maxlevelField;
            }
            set {
                this.mipmap_maxlevelField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float mipmap_bias {
            get {
                return this.mipmap_biasField;
            }
            set {
                this.mipmap_biasField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSampler3DCommon {
        
        private string sourceField;
        
        private fx_sampler_wrap_common wrap_sField;
        
        private fx_sampler_wrap_common wrap_tField;
        
        private fx_sampler_wrap_common wrap_pField;
        
        private fx_sampler_filter_common minfilterField;
        
        private fx_sampler_filter_common magfilterField;
        
        private fx_sampler_filter_common mipfilterField;
        
        private string border_colorField;
        
        private byte mipmap_maxlevelField;
        
        private float mipmap_biasField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        public FxSampler3DCommon() {
            this.wrap_sField = fx_sampler_wrap_common.WRAP;
            this.wrap_tField = fx_sampler_wrap_common.WRAP;
            this.wrap_pField = fx_sampler_wrap_common.WRAP;
            this.minfilterField = fx_sampler_filter_common.NONE;
            this.magfilterField = fx_sampler_filter_common.NONE;
            this.mipfilterField = fx_sampler_filter_common.NONE;
            this.mipmap_maxlevelField = ((byte)(255));
            this.mipmap_biasField = ((float)(0F));
        }
        
        [System.Xml.Serialization.XmlElementAttribute("source", DataType="NCName")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_s {
            get {
                return this.wrap_sField;
            }
            set {
                this.wrap_sField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_t {
            get {
                return this.wrap_tField;
            }
            set {
                this.wrap_tField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_p {
            get {
                return this.wrap_pField;
            }
            set {
                this.wrap_pField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common minfilter {
            get {
                return this.minfilterField;
            }
            set {
                this.minfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common magfilter {
            get {
                return this.magfilterField;
            }
            set {
                this.magfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common mipfilter {
            get {
                return this.mipfilterField;
            }
            set {
                this.mipfilterField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("border_color")]
        public string BorderColor {
            get {
                return this.border_colorField;
            }
            set {
                this.border_colorField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "255")]
        public byte mipmap_maxlevel {
            get {
                return this.mipmap_maxlevelField;
            }
            set {
                this.mipmap_maxlevelField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float mipmap_bias {
            get {
                return this.mipmap_biasField;
            }
            set {
                this.mipmap_biasField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxSampler1DCommon {
        
        private string sourceField;
        
        private fx_sampler_wrap_common wrap_sField;
        
        private fx_sampler_filter_common minfilterField;
        
        private fx_sampler_filter_common magfilterField;
        
        private fx_sampler_filter_common mipfilterField;
        
        private string border_colorField;
        
        private byte mipmap_maxlevelField;
        
        private float mipmap_biasField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        public FxSampler1DCommon() {
            this.wrap_sField = fx_sampler_wrap_common.WRAP;
            this.minfilterField = fx_sampler_filter_common.NONE;
            this.magfilterField = fx_sampler_filter_common.NONE;
            this.mipfilterField = fx_sampler_filter_common.NONE;
            this.mipmap_maxlevelField = ((byte)(0));
            this.mipmap_biasField = ((float)(0F));
        }
        
        [System.Xml.Serialization.XmlElementAttribute("source", DataType="NCName")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_wrap_common.WRAP)]
        public fx_sampler_wrap_common wrap_s {
            get {
                return this.wrap_sField;
            }
            set {
                this.wrap_sField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common minfilter {
            get {
                return this.minfilterField;
            }
            set {
                this.minfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common magfilter {
            get {
                return this.magfilterField;
            }
            set {
                this.magfilterField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(fx_sampler_filter_common.NONE)]
        public fx_sampler_filter_common mipfilter {
            get {
                return this.mipfilterField;
            }
            set {
                this.mipfilterField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("border_color")]
        public string BorderColor {
            get {
                return this.border_colorField;
            }
            set {
                this.border_colorField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte mipmap_maxlevel {
            get {
                return this.mipmap_maxlevelField;
            }
            set {
                this.mipmap_maxlevelField = value;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float mipmap_bias {
            get {
                return this.mipmap_biasField;
            }
            set {
                this.mipmap_biasField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class InputGlobal {
        
        private string semanticField;
        
        private string sourceField;
        
        /// <summary>The semantic attribute is the user-defined meaning of the input connection. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("semantic", DataType="NMTOKEN")]
        public string Semantic {
            get {
                return this.semanticField;
            }
            set {
                this.semanticField = value;
            }
        }
        
        /// <summary>The source attribute indicates the location of the data source. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("source", DataType="anyURI")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxNewparamCommon {
        
        private System.Collections.Generic.List<FxAnnotateCommon> annotateField;
        
        private string semanticField;
        
        private fx_modifier_enum_common modifierField;
        
        private bool modifierFieldSpecified;
        
        private bool boolField;
        
        private string bool2Field;
        
        private string bool3Field;
        
        private string bool4Field;
        
        private long intField;
        
        private string int2Field;
        
        private string int3Field;
        
        private string int4Field;
        
        private double floatField;
        
        private string float2Field;
        
        private string float3Field;
        
        private string float4Field;
        
        private double float1x1Field;
        
        private string float1x2Field;
        
        private string float1x3Field;
        
        private string float1x4Field;
        
        private string float2x1Field;
        
        private string float2x2Field;
        
        private string float2x3Field;
        
        private string float2x4Field;
        
        private string float3x1Field;
        
        private string float3x2Field;
        
        private string float3x3Field;
        
        private string float3x4Field;
        
        private string float4x1Field;
        
        private string float4x2Field;
        
        private string float4x3Field;
        
        private string float4x4Field;
        
        private FxSurfaceCommon surfaceField;
        
        private FxSampler1DCommon sampler1DField;
        
        private FxSampler2DCommon sampler2DField;
        
        private FxSampler3DCommon sampler3DField;
        
        private FxSamplerCUBECommon samplerCUBEField;
        
        private FxSamplerRECTCommon samplerRECTField;
        
        private FxSamplerDEPTHCommon samplerDEPTHField;
        
        private string enumField;
        
        private string sidField;
        
        /// <summary>The annotate element allows you to specify an annotation for this new param.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("annotate")]
        public System.Collections.Generic.List<FxAnnotateCommon> Annotate {
            get {
                if ((this.annotateField == null)) {
                    this.annotateField = new System.Collections.Generic.List<FxAnnotateCommon>();
                }
                return this.annotateField;
            }
            set {
                this.annotateField = value;
            }
        }
        
        /// <summary>The semantic element allows you to specify a semantic for this new param.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("semantic", DataType="NCName")]
        public string Semantic {
            get {
                return this.semanticField;
            }
            set {
                this.semanticField = value;
            }
        }
        
        /// <summary>The modifier element allows you to specify a modifier for this new param.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("modifier")]
        public fx_modifier_enum_common Modifier {
            get {
                return this.modifierField;
            }
            set {
                this.modifierField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modifierSpecified {
            get {
                return this.modifierFieldSpecified;
            }
            set {
                this.modifierFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool")]
        public bool Bool {
            get {
                return this.boolField;
            }
            set {
                this.boolField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool2")]
        public string Bool2 {
            get {
                return this.bool2Field;
            }
            set {
                this.bool2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool3")]
        public string Bool3 {
            get {
                return this.bool3Field;
            }
            set {
                this.bool3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool4")]
        public string Bool4 {
            get {
                return this.bool4Field;
            }
            set {
                this.bool4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int")]
        public long Int {
            get {
                return this.intField;
            }
            set {
                this.intField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int2")]
        public string Int2 {
            get {
                return this.int2Field;
            }
            set {
                this.int2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int3")]
        public string Int3 {
            get {
                return this.int3Field;
            }
            set {
                this.int3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int4")]
        public string Int4 {
            get {
                return this.int4Field;
            }
            set {
                this.int4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float")]
        public double Float {
            get {
                return this.floatField;
            }
            set {
                this.floatField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2")]
        public string Float2 {
            get {
                return this.float2Field;
            }
            set {
                this.float2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3")]
        public string Float3 {
            get {
                return this.float3Field;
            }
            set {
                this.float3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4")]
        public string Float4 {
            get {
                return this.float4Field;
            }
            set {
                this.float4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float1x1")]
        public double Float1x1 {
            get {
                return this.float1x1Field;
            }
            set {
                this.float1x1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float1x2")]
        public string Float1x2 {
            get {
                return this.float1x2Field;
            }
            set {
                this.float1x2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float1x3")]
        public string Float1x3 {
            get {
                return this.float1x3Field;
            }
            set {
                this.float1x3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float1x4")]
        public string Float1x4 {
            get {
                return this.float1x4Field;
            }
            set {
                this.float1x4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2x1")]
        public string Float2x1 {
            get {
                return this.float2x1Field;
            }
            set {
                this.float2x1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2x2")]
        public string Float2x2 {
            get {
                return this.float2x2Field;
            }
            set {
                this.float2x2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2x3")]
        public string Float2x3 {
            get {
                return this.float2x3Field;
            }
            set {
                this.float2x3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2x4")]
        public string Float2x4 {
            get {
                return this.float2x4Field;
            }
            set {
                this.float2x4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3x1")]
        public string Float3x1 {
            get {
                return this.float3x1Field;
            }
            set {
                this.float3x1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3x2")]
        public string Float3x2 {
            get {
                return this.float3x2Field;
            }
            set {
                this.float3x2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3x3")]
        public string Float3x3 {
            get {
                return this.float3x3Field;
            }
            set {
                this.float3x3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3x4")]
        public string Float3x4 {
            get {
                return this.float3x4Field;
            }
            set {
                this.float3x4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4x1")]
        public string Float4x1 {
            get {
                return this.float4x1Field;
            }
            set {
                this.float4x1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4x2")]
        public string Float4x2 {
            get {
                return this.float4x2Field;
            }
            set {
                this.float4x2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4x3")]
        public string Float4x3 {
            get {
                return this.float4x3Field;
            }
            set {
                this.float4x3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4x4")]
        public string Float4x4 {
            get {
                return this.float4x4Field;
            }
            set {
                this.float4x4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("surface")]
        public FxSurfaceCommon Surface {
            get {
                return this.surfaceField;
            }
            set {
                this.surfaceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("sampler1D")]
        public FxSampler1DCommon Sampler1D {
            get {
                return this.sampler1DField;
            }
            set {
                this.sampler1DField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("sampler2D")]
        public FxSampler2DCommon Sampler2D {
            get {
                return this.sampler2DField;
            }
            set {
                this.sampler2DField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("sampler3D")]
        public FxSampler3DCommon Sampler3D {
            get {
                return this.sampler3DField;
            }
            set {
                this.sampler3DField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("samplerCUBE")]
        public FxSamplerCUBECommon SamplerCUBE {
            get {
                return this.samplerCUBEField;
            }
            set {
                this.samplerCUBEField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("samplerRECT")]
        public FxSamplerRECTCommon SamplerRECT {
            get {
                return this.samplerRECTField;
            }
            set {
                this.samplerRECTField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("samplerDEPTH")]
        public FxSamplerDEPTHCommon SamplerDEPTH {
            get {
                return this.samplerDEPTHField;
            }
            set {
                this.samplerDEPTHField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("enum")]
        public string Enum {
            get {
                return this.enumField;
            }
            set {
                this.enumField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class FxAnnotateCommon {
        
        private bool boolField;
        
        private string bool2Field;
        
        private string bool3Field;
        
        private string bool4Field;
        
        private long intField;
        
        private string int2Field;
        
        private string int3Field;
        
        private string int4Field;
        
        private double floatField;
        
        private string float2Field;
        
        private string float3Field;
        
        private string float4Field;
        
        private string float2x2Field;
        
        private string float3x3Field;
        
        private string float4x4Field;
        
        private string stringField;
        
        private string nameField;
        
        [System.Xml.Serialization.XmlElementAttribute("bool")]
        public bool Bool {
            get {
                return this.boolField;
            }
            set {
                this.boolField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool2")]
        public string Bool2 {
            get {
                return this.bool2Field;
            }
            set {
                this.bool2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool3")]
        public string Bool3 {
            get {
                return this.bool3Field;
            }
            set {
                this.bool3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool4")]
        public string Bool4 {
            get {
                return this.bool4Field;
            }
            set {
                this.bool4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int")]
        public long Int {
            get {
                return this.intField;
            }
            set {
                this.intField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int2")]
        public string Int2 {
            get {
                return this.int2Field;
            }
            set {
                this.int2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int3")]
        public string Int3 {
            get {
                return this.int3Field;
            }
            set {
                this.int3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int4")]
        public string Int4 {
            get {
                return this.int4Field;
            }
            set {
                this.int4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float")]
        public double Float {
            get {
                return this.floatField;
            }
            set {
                this.floatField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2")]
        public string Float2 {
            get {
                return this.float2Field;
            }
            set {
                this.float2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3")]
        public string Float3 {
            get {
                return this.float3Field;
            }
            set {
                this.float3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4")]
        public string Float4 {
            get {
                return this.float4Field;
            }
            set {
                this.float4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2x2")]
        public string Float2x2 {
            get {
                return this.float2x2Field;
            }
            set {
                this.float2x2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3x3")]
        public string Float3x3 {
            get {
                return this.float3x3Field;
            }
            set {
                this.float3x3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4x4")]
        public string Float4x4 {
            get {
                return this.float4x4Field;
            }
            set {
                this.float4x4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("string")]
        public string String {
            get {
                return this.stringField;
            }
            set {
                this.stringField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum fx_modifier_enum_common {
        
        CONST,
        
        UNIFORM,
        
        VARYING,
        
        STATIC,
        
        VOLATILE,
        
        EXTERN,
        
        SHARED,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class InputLocalOffset {
        
        private ulong offsetField;
        
        private string semanticField;
        
        private string sourceField;
        
        private ulong setField;
        
        private bool setFieldSpecified;
        
        /// <summary>The offset attribute represents the offset into the list of indices.  If two input elements share 
        ///the same offset, they will be indexed the same.  This works as a simple form of compression for the 
        ///list of indices as well as defining the order the inputs should be used in.  Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("offset")]
        public ulong Offset {
            get {
                return this.offsetField;
            }
            set {
                this.offsetField = value;
            }
        }
        
        /// <summary>The semantic attribute is the user-defined meaning of the input connection. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("semantic", DataType="NMTOKEN")]
        public string Semantic {
            get {
                return this.semanticField;
            }
            set {
                this.semanticField = value;
            }
        }
        
        /// <summary>The source attribute indicates the location of the data source. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("source")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <summary>The set attribute indicates which inputs should be grouped together as a single set. This is helpful 
        ///when multiple inputs share the same semantics. 
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("set")]
        public ulong Set {
            get {
                return this.setField;
            }
            set {
                this.setField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool setSpecified {
            get {
                return this.setFieldSpecified;
            }
            set {
                this.setFieldSpecified = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class TargetableFloat {
        
        private string sidField;
        
        private double valueField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    [System.Xml.Serialization.XmlRootAttribute("instance_camera", Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class InstanceWithExtra {
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string urlField;
        
        private string sidField;
        
        private string nameField;
        
        /// <summary>The extra element may occur any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The url attribute refers to resource to instantiate. This may refer to a local resource using a 
        ///relative URL fragment identifier that begins with the “#” character. The url attribute may refer 
        ///to an external resource using an absolute or relative URL.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("url", DataType="anyURI")]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public partial class InputLocal {
        
        private string semanticField;
        
        private string sourceField;
        
        /// <summary>The semantic attribute is the user-defined meaning of the input connection. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("semantic", DataType="NMTOKEN")]
        public string Semantic {
            get {
                return this.semanticField;
            }
            set {
                this.semanticField = value;
            }
        }
        
        /// <summary>The source attribute indicates the location of the data source. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("source")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
    }
    
    /// <summary>The instance_material element declares the instantiation of a COLLADA material resource.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class InstanceMaterial {
        
        private System.Collections.Generic.List<InstanceMaterialBind> bindField;
        
        private System.Collections.Generic.List<InstanceMaterialBindVertexInput> bind_vertex_inputField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string symbolField;
        
        private string targetField;
        
        private string sidField;
        
        private string nameField;
        
        /// <summary>The bind element binds values to effect parameters upon instantiation.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("bind")]
        public System.Collections.Generic.List<InstanceMaterialBind> Bind {
            get {
                if ((this.bindField == null)) {
                    this.bindField = new System.Collections.Generic.List<InstanceMaterialBind>();
                }
                return this.bindField;
            }
            set {
                this.bindField = value;
            }
        }
        
        /// <summary>The bind_vertex_input element binds vertex inputs to effect parameters upon instantiation.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("bind_vertex_input")]
        public System.Collections.Generic.List<InstanceMaterialBindVertexInput> BindVertexInput {
            get {
                if ((this.bind_vertex_inputField == null)) {
                    this.bind_vertex_inputField = new System.Collections.Generic.List<InstanceMaterialBindVertexInput>();
                }
                return this.bind_vertex_inputField;
            }
            set {
                this.bind_vertex_inputField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The symbol attribute specifies which symbol defined from within the geometry this material binds to.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("symbol", DataType="NCName")]
        public string Symbol {
            get {
                return this.symbolField;
            }
            set {
                this.symbolField = value;
            }
        }
        
        /// <summary>The target attribute specifies the URL of the location of the object to instantiate.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("target", DataType="anyURI")]
        public string Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The bind element binds values to effect parameters upon instantiation.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InstanceMaterialBind {
        
        private string semanticField;
        
        private string targetField;
        
        /// <summary>The semantic attribute specifies which effect parameter to bind.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("semantic", DataType="NCName")]
        public string Semantic {
            get {
                return this.semanticField;
            }
            set {
                this.semanticField = value;
            }
        }
        
        /// <summary>The target attribute specifies the location of the value to bind to the specified semantic. 
        ///This text string is a path-name following a simple syntax described in the “Addressing Syntax” 
        ///section.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("target", DataType="token")]
        public string Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
    }
    
    /// <summary>The bind_vertex_input element binds vertex inputs to effect parameters upon instantiation.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InstanceMaterialBindVertexInput {
        
        private string semanticField;
        
        private string input_semanticField;
        
        private ulong input_setField;
        
        private bool input_setFieldSpecified;
        
        /// <summary>The semantic attribute specifies which effect parameter to bind.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("semantic", DataType="NCName")]
        public string Semantic {
            get {
                return this.semanticField;
            }
            set {
                this.semanticField = value;
            }
        }
        
        /// <summary>The input_semantic attribute specifies which input semantic to bind.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("input_semantic", DataType="NCName")]
        public string InputSemantic {
            get {
                return this.input_semanticField;
            }
            set {
                this.input_semanticField = value;
            }
        }
        
        /// <summary>The input_set attribute specifies which input set to bind. 
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("input_set")]
        public ulong InputSet {
            get {
                return this.input_setField;
            }
            set {
                this.input_setField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool input_setSpecified {
            get {
                return this.input_setFieldSpecified;
            }
            set {
                this.input_setFieldSpecified = value;
            }
        }
    }
    
    /// <summary>The unit element contains descriptive information about unit of measure. It has attributes for 
    ///the name of the unit and the measurement with respect to the meter. The unit element may appear 
    ///zero or one time.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class AssetUnit {
        
        private double meterField;
        
        private string nameField;
        
        public AssetUnit() {
            this.meterField = 1;
            this.nameField = "meter";
        }
        
        /// <summary>The meter attribute specifies the measurement with respect to the meter. The default 
        ///value for the meter attribute is “1.0”.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("meter")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public double Meter {
            get {
                return this.meterField;
            }
            set {
                this.meterField = value;
            }
        }
        
        /// <summary>The name attribute specifies the name of the unit. The default value for the name 
        ///attribute is “meter”.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NMTOKEN")]
        [System.ComponentModel.DefaultValueAttribute("meter")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum UpAxisType {
        
        X_UP,
        
        Y_UP,
        
        Z_UP,
    }
    
    /// <summary>The library_animation_clips element declares a module of animation_clip elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryAnimationClips {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<AnimationClip> animation_clipField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryAnimationClips> IDs = new System.Collections.Generic.Dictionary<string, LibraryAnimationClips>();
        
        /// <summary>The library_animation_clips element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one animation_clip element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("animation_clip")]
        public System.Collections.Generic.List<AnimationClip> AnimationClip {
            get {
                if ((this.animation_clipField == null)) {
                    this.animation_clipField = new System.Collections.Generic.List<AnimationClip>();
                }
                return this.animation_clipField;
            }
            set {
                this.animation_clipField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The animation_clip element defines a section of the animation curves to be used together as 
    ///an animation clip.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class AnimationClip {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<InstanceWithExtra> instance_animationField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        private double startField;
        
        private double endField;
        
        private bool endFieldSpecified;
        
        public static System.Collections.Generic.Dictionary<string, AnimationClip> IDs = new System.Collections.Generic.Dictionary<string, AnimationClip>();
        
        public AnimationClip() {
            this.startField = 0;
        }
        
        /// <summary>The animation_clip element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>The animation_clip must instance at least one animation element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_animation")]
        public System.Collections.Generic.List<InstanceWithExtra> InstanceAnimation {
            get {
                if ((this.instance_animationField == null)) {
                    this.instance_animationField = new System.Collections.Generic.List<InstanceWithExtra>();
                }
                return this.instance_animationField;
            }
            set {
                this.instance_animationField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The start attribute is the time in seconds of the beginning of the clip.  This time is 
        ///the same as that used in the key-frame data and is used to determine which set of 
        ///key-frames will be included in the clip.  The start time does not specify when the clip 
        ///will be played.  If the time falls between two keyframes of a referenced animation, an 
        ///interpolated value should be used.  The default value is 0.0.  Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("start")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public double Start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
            }
        }
        
        /// <summary>The end attribute is the time in seconds of the end of the clip.  This is used in the 
        ///same way as the start time.  If end is not specified, the value is taken to be the end 
        ///time of the longest animation.  Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("end")]
        public double End {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endSpecified {
            get {
                return this.endFieldSpecified;
            }
            set {
                this.endFieldSpecified = value;
            }
        }
    }
    
    /// <summary>The library_animations element declares a module of animation elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryAnimations {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Animation> animationField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryAnimations> IDs = new System.Collections.Generic.Dictionary<string, LibraryAnimations>();
        
        /// <summary>The library_animations element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one animation element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("animation")]
        public System.Collections.Generic.List<Animation> Animation {
            get {
                if ((this.animationField == null)) {
                    this.animationField = new System.Collections.Generic.List<Animation>();
                }
                return this.animationField;
            }
            set {
                this.animationField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The animation element categorizes the declaration of animation information. The animation 
    ///hierarchy contains elements that describe the animation’s key-frame data and sampler functions, 
    ///ordered in such a way to group together animations that should be executed together.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Animation {
        
        private Asset assetField;
        
        private object[] itemsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, Animation> IDs = new System.Collections.Generic.Dictionary<string, Animation>();
        
        /// <summary>The animation element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("animation", typeof(Animation))]
        [System.Xml.Serialization.XmlElementAttribute("channel", typeof(Channel))]
        [System.Xml.Serialization.XmlElementAttribute("sampler", typeof(Sampler))]
        [System.Xml.Serialization.XmlElementAttribute("source", typeof(Source))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The channel element declares an output channel of an animation.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Channel {
        
        private string sourceField;
        
        private string targetField;
        
        /// <summary>The source attribute indicates the location of the sampler using a URL expression. 
        ///The sampler must be declared within the same document. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("source")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <summary>The target attribute indicates the location of the element bound to the output of the sampler. 
        ///This text string is a path-name following a simple syntax described in Address Syntax. 
        ///Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("target", DataType="token")]
        public string Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
    }
    
    /// <summary>The sampler element declares an N-dimensional function used for animation. Animation function curves 
    ///are represented by 1-D sampler elements in COLLADA. The sampler defines sampling points and how to 
    ///interpolate between them.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Sampler {
        
        private System.Collections.Generic.List<InputLocal> inputField;
        
        private string idField;
        
        public static System.Collections.Generic.Dictionary<string, Sampler> IDs = new System.Collections.Generic.Dictionary<string, Sampler>();
        
        /// <summary>The input element must occur at least one time. These inputs are local inputs.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocal> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocal>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
    }
    
    /// <summary>The source element declares a data repository that provides values according to the semantics of an 
    ///input element that refers to it.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Source {
        
        private Asset assetField;
        
        private object itemField;
        
        private SourceTechniqueCommon technique_commonField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, Source> IDs = new System.Collections.Generic.Dictionary<string, Source>();
        
        /// <summary>The source element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("IDREF_array", typeof(IDREFArray))]
        [System.Xml.Serialization.XmlElementAttribute("Name_array", typeof(NameArray))]
        [System.Xml.Serialization.XmlElementAttribute("bool_array", typeof(BoolArray))]
        [System.Xml.Serialization.XmlElementAttribute("float_array", typeof(FloatArray))]
        [System.Xml.Serialization.XmlElementAttribute("int_array", typeof(IntArray))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <summary>The technique common specifies the common method for accessing this source element's data.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique_common")]
        public SourceTechniqueCommon TechniqueCommon {
            get {
                return this.technique_commonField;
            }
            set {
                this.technique_commonField = value;
            }
        }
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The IDREF_array element declares the storage for a homogenous array of ID reference values.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class IDREFArray {
        
        private string idField;
        
        private string nameField;
        
        private ulong countField;
        
        private string valueField;
        
        public static System.Collections.Generic.Dictionary<string, IDREFArray> IDs = new System.Collections.Generic.Dictionary<string, IDREFArray>();
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of values in the array. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="IDREFS")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <summary>The Name_array element declares the storage for a homogenous array of Name string values.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class NameArray {
        
        private string idField;
        
        private string nameField;
        
        private ulong countField;
        
        private string textField;
        
        public static System.Collections.Generic.Dictionary<string, NameArray> IDs = new System.Collections.Generic.Dictionary<string, NameArray>();
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of values in the array. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="Name")]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <summary>The bool_array element declares the storage for a homogenous array of boolean values.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class BoolArray {
        
        private string idField;
        
        private string nameField;
        
        private ulong countField;
        
        private string textField;
        
        public static System.Collections.Generic.Dictionary<string, BoolArray> IDs = new System.Collections.Generic.Dictionary<string, BoolArray>();
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of values in the array. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <summary>The float_array element declares the storage for a homogenous array of floating point values.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class FloatArray {
        
        private string idField;
        
        private string nameField;
        
        private ulong countField;
        
        private short digitsField;
        
        private short magnitudeField;
        
        private string textField;
        
        public static System.Collections.Generic.Dictionary<string, FloatArray> IDs = new System.Collections.Generic.Dictionary<string, FloatArray>();
        
        public FloatArray() {
            this.digitsField = ((short)(6));
            this.magnitudeField = ((short)(38));
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of values in the array. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The digits attribute indicates the number of significant decimal digits of the float values that 
        ///can be contained in the array. The default value is 6. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("digits")]
        [System.ComponentModel.DefaultValueAttribute(typeof(short), "6")]
        public short Digits {
            get {
                return this.digitsField;
            }
            set {
                this.digitsField = value;
            }
        }
        
        /// <summary>The magnitude attribute indicates the largest exponent of the float values that can be contained 
        ///in the array. The default value is 38. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("magnitude")]
        [System.ComponentModel.DefaultValueAttribute(typeof(short), "38")]
        public short Magnitude {
            get {
                return this.magnitudeField;
            }
            set {
                this.magnitudeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <summary>The int_array element declares the storage for a homogenous array of integer values.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class IntArray {
        
        private string idField;
        
        private string nameField;
        
        private ulong countField;
        
        private string minInclusiveField;
        
        private string maxInclusiveField;
        
        private string textField;
        
        public static System.Collections.Generic.Dictionary<string, IntArray> IDs = new System.Collections.Generic.Dictionary<string, IntArray>();
        
        public IntArray() {
            this.minInclusiveField = "-2147483648";
            this.maxInclusiveField = "2147483647";
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of values in the array. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The minInclusive attribute indicates the smallest integer value that can be contained in 
        ///the array. The default value is –2147483648. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("minInclusive", DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("-2147483648")]
        public string MinInclusive {
            get {
                return this.minInclusiveField;
            }
            set {
                this.minInclusiveField = value;
            }
        }
        
        /// <summary>The maxInclusive attribute indicates the largest integer value that can be contained in 
        ///the array. The default value is 2147483647. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("maxInclusive", DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("2147483647")]
        public string MaxInclusive {
            get {
                return this.maxInclusiveField;
            }
            set {
                this.maxInclusiveField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <summary>The technique common specifies the common method for accessing this source element's data.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SourceTechniqueCommon {
        
        private Accessor accessorField;
        
        /// <summary>The source's technique_common must have one and only one accessor.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("accessor")]
        public Accessor Accessor {
            get {
                return this.accessorField;
            }
            set {
                this.accessorField = value;
            }
        }
    }
    
    /// <summary>The accessor element declares an access pattern to one of the array elements: float_array, 
    ///int_array, Name_array, bool_array, and IDREF_array. The accessor element describes access 
    ///to arrays that are organized in either an interleaved or non-interleaved manner, depending 
    ///on the offset and stride attributes.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Accessor {
        
        private System.Collections.Generic.List<Param> paramField;
        
        private ulong countField;
        
        private ulong offsetField;
        
        private string sourceField;
        
        private ulong strideField;
        
        public Accessor() {
            this.offsetField = ((ulong)(0m));
            this.strideField = ((ulong)(1m));
        }
        
        /// <summary>The accessor element may have any number of param elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("param")]
        public System.Collections.Generic.List<Param> Param {
            get {
                if ((this.paramField == null)) {
                    this.paramField = new System.Collections.Generic.List<Param>();
                }
                return this.paramField;
            }
            set {
                this.paramField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of times the array is accessed. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The offset attribute indicates the index of the first value to be read from the array. 
        ///The default value is 0. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("offset")]
        [System.ComponentModel.DefaultValueAttribute(typeof(ulong), "0")]
        public ulong Offset {
            get {
                return this.offsetField;
            }
            set {
                this.offsetField = value;
            }
        }
        
        /// <summary>The source attribute indicates the location of the array to access using a URL expression. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("source", DataType="anyURI")]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <summary>The stride attribute indicates number of values to be considered a unit during each access to 
        ///the array. The default value is 1, indicating that a single value is accessed. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("stride")]
        [System.ComponentModel.DefaultValueAttribute(typeof(ulong), "1")]
        public ulong Stride {
            get {
                return this.strideField;
            }
            set {
                this.strideField = value;
            }
        }
    }
    
    /// <summary>The param element declares parametric information regarding its parent element.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Param {
        
        private string nameField;
        
        private string sidField;
        
        private string semanticField;
        
        private string typeField;
        
        private string valueField;
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The semantic attribute is the user-defined meaning of the parameter. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("semantic", DataType="NMTOKEN")]
        public string Semantic {
            get {
                return this.semanticField;
            }
            set {
                this.semanticField = value;
            }
        }
        
        /// <summary>The type attribute indicates the type of the value data. This text string must be understood 
        ///by the application. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("type", DataType="NMTOKEN")]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <summary>The library_cameras element declares a module of camera elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryCameras {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Camera> cameraField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryCameras> IDs = new System.Collections.Generic.Dictionary<string, LibraryCameras>();
        
        /// <summary>The library_cameras element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one camera element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("camera")]
        public System.Collections.Generic.List<Camera> Camera {
            get {
                if ((this.cameraField == null)) {
                    this.cameraField = new System.Collections.Generic.List<Camera>();
                }
                return this.cameraField;
            }
            set {
                this.cameraField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The camera element declares a view into the scene hierarchy or scene graph. The camera contains 
    ///elements that describe the camera’s optics and imager.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Camera {
        
        private Asset assetField;
        
        private CameraOptics opticsField;
        
        private CameraImager imagerField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, Camera> IDs = new System.Collections.Generic.Dictionary<string, Camera>();
        
        /// <summary>The camera element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>Optics represents the apparatus on a camera that projects the image onto the image sensor.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("optics")]
        public CameraOptics Optics {
            get {
                return this.opticsField;
            }
            set {
                this.opticsField = value;
            }
        }
        
        /// <summary>Imagers represent the image sensor of a camera (for example film or CCD).
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("imager")]
        public CameraImager Imager {
            get {
                return this.imagerField;
            }
            set {
                this.imagerField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>Optics represents the apparatus on a camera that projects the image onto the image sensor.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CameraOptics {
        
        private CameraOpticsTechniqueCommon technique_commonField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>The technique_common element specifies the optics information for the common profile 
        ///which all COLLADA implementations need to support.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique_common")]
        public CameraOpticsTechniqueCommon TechniqueCommon {
            get {
                return this.technique_commonField;
            }
            set {
                this.technique_commonField = value;
            }
        }
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>The technique_common element specifies the optics information for the common profile 
    ///which all COLLADA implementations need to support.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CameraOpticsTechniqueCommon {
        
        private object itemField;
        
        [System.Xml.Serialization.XmlElementAttribute("orthographic", typeof(CameraOpticsTechniqueCommonOrthographic))]
        [System.Xml.Serialization.XmlElementAttribute("perspective", typeof(CameraOpticsTechniqueCommonPerspective))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <summary>The orthographic element describes the field of view of an orthographic camera.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CameraOpticsTechniqueCommonOrthographic {
        
        private TargetableFloat[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        private TargetableFloat znearField;
        
        private TargetableFloat zfarField;
        
        [System.Xml.Serialization.XmlElementAttribute("aspect_ratio", typeof(TargetableFloat))]
        [System.Xml.Serialization.XmlElementAttribute("xmag", typeof(TargetableFloat))]
        [System.Xml.Serialization.XmlElementAttribute("ymag", typeof(TargetableFloat))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public TargetableFloat[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <summary>The znear element contains a floating point number that describes the distance to the near 
        ///clipping plane. The znear element must occur exactly once.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("znear")]
        public TargetableFloat Znear {
            get {
                return this.znearField;
            }
            set {
                this.znearField = value;
            }
        }
        
        /// <summary>The zfar element contains a floating point number that describes the distance to the far 
        ///clipping plane. The zfar element must occur exactly once.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("zfar")]
        public TargetableFloat Zfar {
            get {
                return this.zfarField;
            }
            set {
                this.zfarField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        aspect_ratio,
        
        xmag,
        
        ymag,
    }
    
    /// <summary>The perspective element describes the optics of a perspective camera.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CameraOpticsTechniqueCommonPerspective {
        
        private TargetableFloat[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        private TargetableFloat znearField;
        
        private TargetableFloat zfarField;
        
        [System.Xml.Serialization.XmlElementAttribute("aspect_ratio", typeof(TargetableFloat))]
        [System.Xml.Serialization.XmlElementAttribute("xfov", typeof(TargetableFloat))]
        [System.Xml.Serialization.XmlElementAttribute("yfov", typeof(TargetableFloat))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public TargetableFloat[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <summary>The znear element contains a floating point number that describes the distance to the near 
        ///clipping plane. The znear element must occur exactly once.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("znear")]
        public TargetableFloat Znear {
            get {
                return this.znearField;
            }
            set {
                this.znearField = value;
            }
        }
        
        /// <summary>The zfar element contains a floating point number that describes the distance to the far 
        ///clipping plane. The zfar element must occur exactly once.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("zfar")]
        public TargetableFloat Zfar {
            get {
                return this.zfarField;
            }
            set {
                this.zfarField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IncludeInSchema=false)]
    public enum ItemsChoiceType1 {
        
        aspect_ratio,
        
        xfov,
        
        yfov,
    }
    
    /// <summary>Imagers represent the image sensor of a camera (for example film or CCD).
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CameraImager {
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///There is no common technique for imager.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>The library_controllers element declares a module of controller elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryControllers {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Controller> controllerField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryControllers> IDs = new System.Collections.Generic.Dictionary<string, LibraryControllers>();
        
        /// <summary>The library_controllers element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one controller element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("controller")]
        public System.Collections.Generic.List<Controller> Controller {
            get {
                if ((this.controllerField == null)) {
                    this.controllerField = new System.Collections.Generic.List<Controller>();
                }
                return this.controllerField;
            }
            set {
                this.controllerField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The controller element categorizes the declaration of generic control information.
    ///A controller is a device or mechanism that manages and directs the operations of another object.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Controller {
        
        private Asset assetField;
        
        private object itemField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, Controller> IDs = new System.Collections.Generic.Dictionary<string, Controller>();
        
        /// <summary>The controller element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("morph", typeof(Morph))]
        [System.Xml.Serialization.XmlElementAttribute("skin", typeof(Skin))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The morph element describes the data required to blend between sets of static meshes. Each 
    ///possible mesh that can be blended (a morph target) must be specified.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Morph {
        
        private System.Collections.Generic.List<Source> sourceField;
        
        private MorphTargets targetsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private MorphMethodType methodField;
        
        private string source1Field;
        
        public Morph() {
            this.methodField = MorphMethodType.NORMALIZED;
        }
        
        /// <summary>The source attribute indicates the base mesh. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public System.Collections.Generic.List<Source> Source {
            get {
                if ((this.sourceField == null)) {
                    this.sourceField = new System.Collections.Generic.List<Source>();
                }
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <summary>The targets element declares the morph targets, their weights and any user defined attributes 
        ///associated with them.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("targets")]
        public MorphTargets Targets {
            get {
                return this.targetsField;
            }
            set {
                this.targetsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The method attribute specifies the which blending technique to use. The accepted values are 
        ///NORMALIZED, and RELATIVE. The default value if not specified is NORMALIZED.  Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("method")]
        [System.ComponentModel.DefaultValueAttribute(MorphMethodType.NORMALIZED)]
        public MorphMethodType Method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("source", DataType="anyURI")]
        public string Source1 {
            get {
                return this.source1Field;
            }
            set {
                this.source1Field = value;
            }
        }
    }
    
    /// <summary>The targets element declares the morph targets, their weights and any user defined attributes 
    ///associated with them.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class MorphTargets {
        
        private System.Collections.Generic.List<InputLocal> inputField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>The input element must occur at least twice. These inputs are local inputs.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocal> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocal>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum MorphMethodType {
        
        NORMALIZED,
        
        RELATIVE,
    }
    
    /// <summary>The skin element contains vertex and primitive information sufficient to describe blend-weight skinning.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Skin {
        
        private string bind_shape_matrixField;
        
        private System.Collections.Generic.List<Source> sourceField;
        
        private SkinJoints jointsField;
        
        private SkinVertexWeights vertex_weightsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string source1Field;
        
        /// <summary>This provides extra information about the position and orientation of the base mesh before binding. 
        ///If bind_shape_matrix is not specified then an identity matrix may be used as the bind_shape_matrix.
        ///The bind_shape_matrix element may occur zero or one times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("bind_shape_matrix")]
        public string BindShapeMatrix {
            get {
                return this.bind_shape_matrixField;
            }
            set {
                this.bind_shape_matrixField = value;
            }
        }
        
        /// <summary>The source attribute contains a URI reference to the base mesh, (a static mesh or a morphed mesh).
        ///This also provides the bind-shape of the skinned mesh.  Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public System.Collections.Generic.List<Source> Source {
            get {
                if ((this.sourceField == null)) {
                    this.sourceField = new System.Collections.Generic.List<Source>();
                }
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <summary>The joints element associates joint, or skeleton, nodes with attribute data.  
        ///In COLLADA, this is specified by the inverse bind matrix of each joint (influence) in the skeleton.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("joints")]
        public SkinJoints Joints {
            get {
                return this.jointsField;
            }
            set {
                this.jointsField = value;
            }
        }
        
        /// <summary>The vertex_weights element associates a set of joint-weight pairs with each vertex in the base mesh.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("vertex_weights")]
        public SkinVertexWeights VertexWeights {
            get {
                return this.vertex_weightsField;
            }
            set {
                this.vertex_weightsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("source", DataType="anyURI")]
        public string Source1 {
            get {
                return this.source1Field;
            }
            set {
                this.source1Field = value;
            }
        }
    }
    
    /// <summary>The joints element associates joint, or skeleton, nodes with attribute data.  
    ///In COLLADA, this is specified by the inverse bind matrix of each joint (influence) in the skeleton.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SkinJoints {
        
        private System.Collections.Generic.List<InputLocal> inputField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>The input element must occur at least twice. These inputs are local inputs.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocal> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocal>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>The vertex_weights element associates a set of joint-weight pairs with each vertex in the base mesh.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SkinVertexWeights {
        
        private System.Collections.Generic.List<InputLocalOffset> inputField;
        
        private string vcountField;
        
        private string vField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private ulong countField;
        
        /// <summary>The input element must occur at least twice.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocalOffset> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocalOffset>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The vcount element contains a list of integers describing the number of influences for each vertex.
        ///The vcount element may occur once.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("vcount")]
        public string Vcount {
            get {
                return this.vcountField;
            }
            set {
                this.vcountField = value;
            }
        }
        
        /// <summary>The v element describes which bones and attributes are associated with each vertex.  An index 
        ///of –1 into the array of joints refers to the bind shape.  Weights should be normalized before use.
        ///The v element must occur zero or one times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("v")]
        public string V {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The count attribute describes the number of vertices in the base mesh. Required element. 
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
    }
    
    /// <summary>The library_effects element declares a module of effect elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryEffects {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Effect> effectField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryEffects> IDs = new System.Collections.Generic.Dictionary<string, LibraryEffects>();
        
        /// <summary>The library_effects element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one effect element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("effect")]
        public System.Collections.Generic.List<Effect> Effect {
            get {
                if ((this.effectField == null)) {
                    this.effectField = new System.Collections.Generic.List<Effect>();
                }
                return this.effectField;
            }
            set {
                this.effectField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>A self contained description of a shader effect.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Effect {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<FxAnnotateCommon> annotateField;
        
        private System.Collections.Generic.List<Image> imageField;
        
        private System.Collections.Generic.List<FxNewparamCommon> newparamField;
        
        private EffectFxProfileAbstractProfileCOMMON[] itemsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, Effect> IDs = new System.Collections.Generic.Dictionary<string, Effect>();
        
        /// <summary>The effect element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>The annotate element allows you to specify an annotation on this effect.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("annotate")]
        public System.Collections.Generic.List<FxAnnotateCommon> Annotate {
            get {
                if ((this.annotateField == null)) {
                    this.annotateField = new System.Collections.Generic.List<FxAnnotateCommon>();
                }
                return this.annotateField;
            }
            set {
                this.annotateField = value;
            }
        }
        
        /// <summary>The image element allows you to create image resources which can be shared by multipe profiles.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("image")]
        public System.Collections.Generic.List<Image> Image {
            get {
                if ((this.imageField == null)) {
                    this.imageField = new System.Collections.Generic.List<Image>();
                }
                return this.imageField;
            }
            set {
                this.imageField = value;
            }
        }
        
        /// <summary>The newparam element allows you to create new effect parameters which can be shared by multipe profiles.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("newparam")]
        public System.Collections.Generic.List<FxNewparamCommon> Newparam {
            get {
                if ((this.newparamField == null)) {
                    this.newparamField = new System.Collections.Generic.List<FxNewparamCommon>();
                }
                return this.newparamField;
            }
            set {
                this.newparamField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("profile_COMMON")]
        public EffectFxProfileAbstractProfileCOMMON[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The image element declares the storage for the graphical representation of an object. 
    ///The image element best describes raster image data, but can conceivably handle other 
    ///forms of imagery. The image elements allows for specifying an external image file with 
    ///the init_from element or embed image data with the data element.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Image {
        
        private Asset assetField;
        
        private object itemField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        private string formatField;
        
        private ulong heightField;
        
        private bool heightFieldSpecified;
        
        private ulong widthField;
        
        private bool widthFieldSpecified;
        
        private ulong depthField;
        
        public static System.Collections.Generic.Dictionary<string, Image> IDs = new System.Collections.Generic.Dictionary<string, Image>();
        
        public Image() {
            this.depthField = ((ulong)(1m));
        }
        
        /// <summary>The image element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("data", typeof(byte[]), DataType="hexBinary")]
        [System.Xml.Serialization.XmlElementAttribute("init_from", typeof(string), DataType="anyURI")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The format attribute is a text string value that indicates the image format. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("format", DataType="token")]
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <summary>The height attribute is an integer value that indicates the height of the image in pixel 
        ///units. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("height")]
        public ulong Height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified {
            get {
                return this.heightFieldSpecified;
            }
            set {
                this.heightFieldSpecified = value;
            }
        }
        
        /// <summary>The width attribute is an integer value that indicates the width of the image in pixel units. 
        ///Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("width")]
        public ulong Width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified {
            get {
                return this.widthFieldSpecified;
            }
            set {
                this.widthFieldSpecified = value;
            }
        }
        
        /// <summary>The depth attribute is an integer value that indicates the depth of the image in pixel units. 
        ///A 2-D image has a depth of 1, which is also the default value. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("depth")]
        [System.ComponentModel.DefaultValueAttribute(typeof(ulong), "1")]
        public ulong Depth {
            get {
                return this.depthField;
            }
            set {
                this.depthField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute("profile_COMMON", Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class EffectFxProfileAbstractProfileCOMMON {
        
        private Asset assetField;
        
        private object[] itemsField;
        
        private EffectFxProfileAbstractProfileCOMMONTechnique techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        public static System.Collections.Generic.Dictionary<string, EffectFxProfileAbstractProfileCOMMON> IDs = new System.Collections.Generic.Dictionary<string, EffectFxProfileAbstractProfileCOMMON>();
        
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("image", typeof(Image))]
        [System.Xml.Serialization.XmlElementAttribute("newparam", typeof(CommonNewparamType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public EffectFxProfileAbstractProfileCOMMONTechnique Technique {
            get {
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EffectFxProfileAbstractProfileCOMMONTechnique {
        
        private Asset assetField;
        
        private object[] itemsField;
        
        private object itemField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string sidField;
        
        public static System.Collections.Generic.Dictionary<string, EffectFxProfileAbstractProfileCOMMONTechnique> IDs = new System.Collections.Generic.Dictionary<string, EffectFxProfileAbstractProfileCOMMONTechnique>();
        
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("image", typeof(Image))]
        [System.Xml.Serialization.XmlElementAttribute("newparam", typeof(CommonNewparamType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("blinn", typeof(EffectFxProfileAbstractProfileCOMMONTechniqueBlinn))]
        [System.Xml.Serialization.XmlElementAttribute("constant", typeof(EffectFxProfileAbstractProfileCOMMONTechniqueConstant))]
        [System.Xml.Serialization.XmlElementAttribute("lambert", typeof(EffectFxProfileAbstractProfileCOMMONTechniqueLambert))]
        [System.Xml.Serialization.XmlElementAttribute("phong", typeof(EffectFxProfileAbstractProfileCOMMONTechniquePhong))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EffectFxProfileAbstractProfileCOMMONTechniqueBlinn {
        
        private CommonColorOrTextureType emissionField;
        
        private CommonColorOrTextureType ambientField;
        
        private CommonColorOrTextureType diffuseField;
        
        private CommonColorOrTextureType specularField;
        
        private CommonFloatOrParamType shininessField;
        
        private CommonColorOrTextureType reflectiveField;
        
        private CommonFloatOrParamType reflectivityField;
        
        private CommonTransparentType transparentField;
        
        private CommonFloatOrParamType transparencyField;
        
        private CommonFloatOrParamType index_of_refractionField;
        
        [System.Xml.Serialization.XmlElementAttribute("emission")]
        public CommonColorOrTextureType Emission {
            get {
                return this.emissionField;
            }
            set {
                this.emissionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ambient")]
        public CommonColorOrTextureType Ambient {
            get {
                return this.ambientField;
            }
            set {
                this.ambientField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("diffuse")]
        public CommonColorOrTextureType Diffuse {
            get {
                return this.diffuseField;
            }
            set {
                this.diffuseField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("specular")]
        public CommonColorOrTextureType Specular {
            get {
                return this.specularField;
            }
            set {
                this.specularField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("shininess")]
        public CommonFloatOrParamType Shininess {
            get {
                return this.shininessField;
            }
            set {
                this.shininessField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reflective")]
        public CommonColorOrTextureType Reflective {
            get {
                return this.reflectiveField;
            }
            set {
                this.reflectiveField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reflectivity")]
        public CommonFloatOrParamType Reflectivity {
            get {
                return this.reflectivityField;
            }
            set {
                this.reflectivityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("transparent")]
        public CommonTransparentType Transparent {
            get {
                return this.transparentField;
            }
            set {
                this.transparentField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("transparency")]
        public CommonFloatOrParamType Transparency {
            get {
                return this.transparencyField;
            }
            set {
                this.transparencyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("index_of_refraction")]
        public CommonFloatOrParamType IndexOfRefraction {
            get {
                return this.index_of_refractionField;
            }
            set {
                this.index_of_refractionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EffectFxProfileAbstractProfileCOMMONTechniqueConstant {
        
        private CommonColorOrTextureType emissionField;
        
        private CommonColorOrTextureType reflectiveField;
        
        private CommonFloatOrParamType reflectivityField;
        
        private CommonTransparentType transparentField;
        
        private CommonFloatOrParamType transparencyField;
        
        private CommonFloatOrParamType index_of_refractionField;
        
        [System.Xml.Serialization.XmlElementAttribute("emission")]
        public CommonColorOrTextureType Emission {
            get {
                return this.emissionField;
            }
            set {
                this.emissionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reflective")]
        public CommonColorOrTextureType Reflective {
            get {
                return this.reflectiveField;
            }
            set {
                this.reflectiveField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reflectivity")]
        public CommonFloatOrParamType Reflectivity {
            get {
                return this.reflectivityField;
            }
            set {
                this.reflectivityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("transparent")]
        public CommonTransparentType Transparent {
            get {
                return this.transparentField;
            }
            set {
                this.transparentField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("transparency")]
        public CommonFloatOrParamType Transparency {
            get {
                return this.transparencyField;
            }
            set {
                this.transparencyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("index_of_refraction")]
        public CommonFloatOrParamType IndexOfRefraction {
            get {
                return this.index_of_refractionField;
            }
            set {
                this.index_of_refractionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EffectFxProfileAbstractProfileCOMMONTechniqueLambert {
        
        private CommonColorOrTextureType emissionField;
        
        private CommonColorOrTextureType ambientField;
        
        private CommonColorOrTextureType diffuseField;
        
        private CommonColorOrTextureType reflectiveField;
        
        private CommonFloatOrParamType reflectivityField;
        
        private CommonTransparentType transparentField;
        
        private CommonFloatOrParamType transparencyField;
        
        private CommonFloatOrParamType index_of_refractionField;
        
        [System.Xml.Serialization.XmlElementAttribute("emission")]
        public CommonColorOrTextureType Emission {
            get {
                return this.emissionField;
            }
            set {
                this.emissionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ambient")]
        public CommonColorOrTextureType Ambient {
            get {
                return this.ambientField;
            }
            set {
                this.ambientField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("diffuse")]
        public CommonColorOrTextureType Diffuse {
            get {
                return this.diffuseField;
            }
            set {
                this.diffuseField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reflective")]
        public CommonColorOrTextureType Reflective {
            get {
                return this.reflectiveField;
            }
            set {
                this.reflectiveField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reflectivity")]
        public CommonFloatOrParamType Reflectivity {
            get {
                return this.reflectivityField;
            }
            set {
                this.reflectivityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("transparent")]
        public CommonTransparentType Transparent {
            get {
                return this.transparentField;
            }
            set {
                this.transparentField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("transparency")]
        public CommonFloatOrParamType Transparency {
            get {
                return this.transparencyField;
            }
            set {
                this.transparencyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("index_of_refraction")]
        public CommonFloatOrParamType IndexOfRefraction {
            get {
                return this.index_of_refractionField;
            }
            set {
                this.index_of_refractionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EffectFxProfileAbstractProfileCOMMONTechniquePhong {
        
        private CommonColorOrTextureType emissionField;
        
        private CommonColorOrTextureType ambientField;
        
        private CommonColorOrTextureType diffuseField;
        
        private CommonColorOrTextureType specularField;
        
        private CommonFloatOrParamType shininessField;
        
        private CommonColorOrTextureType reflectiveField;
        
        private CommonFloatOrParamType reflectivityField;
        
        private CommonTransparentType transparentField;
        
        private CommonFloatOrParamType transparencyField;
        
        private CommonFloatOrParamType index_of_refractionField;
        
        [System.Xml.Serialization.XmlElementAttribute("emission")]
        public CommonColorOrTextureType Emission {
            get {
                return this.emissionField;
            }
            set {
                this.emissionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ambient")]
        public CommonColorOrTextureType Ambient {
            get {
                return this.ambientField;
            }
            set {
                this.ambientField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("diffuse")]
        public CommonColorOrTextureType Diffuse {
            get {
                return this.diffuseField;
            }
            set {
                this.diffuseField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("specular")]
        public CommonColorOrTextureType Specular {
            get {
                return this.specularField;
            }
            set {
                this.specularField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("shininess")]
        public CommonFloatOrParamType Shininess {
            get {
                return this.shininessField;
            }
            set {
                this.shininessField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reflective")]
        public CommonColorOrTextureType Reflective {
            get {
                return this.reflectiveField;
            }
            set {
                this.reflectiveField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reflectivity")]
        public CommonFloatOrParamType Reflectivity {
            get {
                return this.reflectivityField;
            }
            set {
                this.reflectivityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("transparent")]
        public CommonTransparentType Transparent {
            get {
                return this.transparentField;
            }
            set {
                this.transparentField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("transparency")]
        public CommonFloatOrParamType Transparency {
            get {
                return this.transparencyField;
            }
            set {
                this.transparencyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("index_of_refraction")]
        public CommonFloatOrParamType IndexOfRefraction {
            get {
                return this.index_of_refractionField;
            }
            set {
                this.index_of_refractionField = value;
            }
        }
    }
    
    /// <summary>The library_force_fields element declares a module of force_field elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryForceFields {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<ForceField> force_fieldField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryForceFields> IDs = new System.Collections.Generic.Dictionary<string, LibraryForceFields>();
        
        /// <summary>The library_force_fields element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one force_field element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("force_field")]
        public System.Collections.Generic.List<ForceField> ForceField {
            get {
                if ((this.force_fieldField == null)) {
                    this.force_fieldField = new System.Collections.Generic.List<ForceField>();
                }
                return this.force_fieldField;
            }
            set {
                this.force_fieldField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>A general container for force-fields. At the moment, it only has techniques and extra elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class ForceField {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, ForceField> IDs = new System.Collections.Generic.Dictionary<string, ForceField>();
        
        /// <summary>The force_field element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>This element must contain at least one non-common profile technique.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The library_geometries element declares a module of geometry elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryGeometries {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Geometry> geometryField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryGeometries> IDs = new System.Collections.Generic.Dictionary<string, LibraryGeometries>();
        
        /// <summary>The library_geometries element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one geometry element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("geometry")]
        public System.Collections.Generic.List<Geometry> Geometry {
            get {
                if ((this.geometryField == null)) {
                    this.geometryField = new System.Collections.Generic.List<Geometry>();
                }
                return this.geometryField;
            }
            set {
                this.geometryField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>Geometry describes the visual shape and appearance of an object in the scene.
    ///The geometry element categorizes the declaration of geometric information. Geometry is a 
    ///branch of mathematics that deals with the measurement, properties, and relationships of 
    ///points, lines, angles, surfaces, and solids.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Geometry {
        
        private Asset assetField;
        
        private object itemField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, Geometry> IDs = new System.Collections.Generic.Dictionary<string, Geometry>();
        
        /// <summary>The geometry element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("convex_mesh", typeof(ConvexMesh))]
        [System.Xml.Serialization.XmlElementAttribute("mesh", typeof(Mesh))]
        [System.Xml.Serialization.XmlElementAttribute("spline", typeof(Spline))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The definition of the convex_mesh element is identical to the mesh element with the exception that 
    ///instead of a complete description (source, vertices, polygons etc.), it may simply point to another 
    ///geometry to derive its shape. The latter case means that the convex hull of that geometry should 
    ///be computed and is indicated by the optional “convex_hull_of” attribute.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class ConvexMesh {
        
        private System.Collections.Generic.List<Source> sourceField;
        
        private Vertices verticesField;
        
        private object[] itemsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string convex_hull_ofField;
        
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public System.Collections.Generic.List<Source> Source {
            get {
                if ((this.sourceField == null)) {
                    this.sourceField = new System.Collections.Generic.List<Source>();
                }
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("vertices")]
        public Vertices Vertices {
            get {
                return this.verticesField;
            }
            set {
                this.verticesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("lines", typeof(Lines))]
        [System.Xml.Serialization.XmlElementAttribute("linestrips", typeof(Linestrips))]
        [System.Xml.Serialization.XmlElementAttribute("polygons", typeof(Polygons))]
        [System.Xml.Serialization.XmlElementAttribute("polylist", typeof(Polylist))]
        [System.Xml.Serialization.XmlElementAttribute("triangles", typeof(Triangles))]
        [System.Xml.Serialization.XmlElementAttribute("trifans", typeof(Trifans))]
        [System.Xml.Serialization.XmlElementAttribute("tristrips", typeof(Tristrips))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The convex_hull_of attribute is a URI string of geometry to compute the convex hull of. 
        ///Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("convex_hull_of", DataType="anyURI")]
        public string ConvexHullOf {
            get {
                return this.convex_hull_ofField;
            }
            set {
                this.convex_hull_ofField = value;
            }
        }
    }
    
    /// <summary>The vertices element declares the attributes and identity of mesh-vertices. The vertices element
    ///describes mesh-vertices in a mesh geometry. The mesh-vertices represent the position (identity) 
    ///of the vertices comprising the mesh and other vertex attributes that are invariant to tessellation.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Vertices {
        
        private System.Collections.Generic.List<InputLocal> inputField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, Vertices> IDs = new System.Collections.Generic.Dictionary<string, Vertices>();
        
        /// <summary>The input element must occur at least one time. These inputs are local inputs.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocal> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocal>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This 
        ///value must be unique within the instance document. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The lines element provides the information needed to bind vertex attributes together and then 
    ///organize those vertices into individual lines. Each line described by the mesh has two vertices. 
    ///The first line is formed from first and second vertices. The second line is formed from the 
    ///third and fourth vertices and so on.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Lines {
        
        private System.Collections.Generic.List<InputLocalOffset> inputField;
        
        private string pField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string nameField;
        
        private ulong countField;
        
        private string materialField;
        
        /// <summary>The input element may occur any number of times. This input is a local input with the offset 
        ///and set attributes.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocalOffset> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocalOffset>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The p element may occur once.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("p")]
        public string P {
            get {
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of line primitives. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The material attribute declares a symbol for a material. This symbol is bound to a material at 
        ///the time of instantiation. If the material attribute is not specified then the lighting and 
        ///shading results are application defined. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("material", DataType="NCName")]
        public string Material {
            get {
                return this.materialField;
            }
            set {
                this.materialField = value;
            }
        }
    }
    
    /// <summary>The linestrips element provides the information needed to bind vertex attributes together and 
    ///then organize those vertices into connected line-strips. Each line-strip described by the mesh 
    ///has an arbitrary number of vertices. Each line segment within the line-strip is formed from the 
    ///current vertex and the preceding vertex.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Linestrips {
        
        private System.Collections.Generic.List<InputLocalOffset> inputField;
        
        private System.Collections.Generic.List<string> pField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string nameField;
        
        private ulong countField;
        
        private string materialField;
        
        /// <summary>The input element may occur any number of times. This input is a local input with the offset 
        ///and set attributes.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocalOffset> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocalOffset>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The linestrips element may have any number of p elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("p")]
        public System.Collections.Generic.List<string> P {
            get {
                if ((this.pField == null)) {
                    this.pField = new System.Collections.Generic.List<string>();
                }
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of linestrip primitives. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The material attribute declares a symbol for a material. This symbol is bound to a material 
        ///at the time of instantiation. If the material attribute is not specified then the lighting 
        ///and shading results are application defined. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("material", DataType="NCName")]
        public string Material {
            get {
                return this.materialField;
            }
            set {
                this.materialField = value;
            }
        }
    }
    
    /// <summary>The polygons element provides the information needed to bind vertex attributes together and 
    ///then organize those vertices into individual polygons. The polygons described can contain 
    ///arbitrary numbers of vertices. These polygons may be self intersecting and may also contain holes.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Polygons {
        
        private System.Collections.Generic.List<InputLocalOffset> inputField;
        
        private object[] itemsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string nameField;
        
        private ulong countField;
        
        private string materialField;
        
        /// <summary>The input element may occur any number of times. This input is a local input with the 
        ///offset and set attributes.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocalOffset> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocalOffset>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ph", typeof(PolygonsPH))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of polygon primitives. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The material attribute declares a symbol for a material. This symbol is bound to a material 
        ///at the time of instantiation. If the material attribute is not specified then the lighting 
        ///and shading results are application defined. Optional attribute. 
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("material", DataType="NCName")]
        public string Material {
            get {
                return this.materialField;
            }
            set {
                this.materialField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PolygonsPH {
        
        private string pField;
        
        private System.Collections.Generic.List<string> hField;
        
        [System.Xml.Serialization.XmlElementAttribute("p")]
        public string P {
            get {
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("h")]
        public System.Collections.Generic.List<string> H {
            get {
                if ((this.hField == null)) {
                    this.hField = new System.Collections.Generic.List<string>();
                }
                return this.hField;
            }
            set {
                this.hField = value;
            }
        }
    }
    
    /// <summary>The polylist element provides the information needed to bind vertex attributes together and 
    ///then organize those vertices into individual polygons. The polygons described in polylist can 
    ///contain arbitrary numbers of vertices. Unlike the polygons element, the polylist element cannot 
    ///contain polygons with holes.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Polylist {
        
        private System.Collections.Generic.List<InputLocalOffset> inputField;
        
        private string vcountField;
        
        private string pField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string nameField;
        
        private ulong countField;
        
        private string materialField;
        
        /// <summary>The input element may occur any number of times. This input is a local input with the 
        ///offset and set attributes.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocalOffset> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocalOffset>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The vcount element contains a list of integers describing the number of sides for each polygon 
        ///described by the polylist element. The vcount element may occur once.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("vcount")]
        public string Vcount {
            get {
                return this.vcountField;
            }
            set {
                this.vcountField = value;
            }
        }
        
        /// <summary>The p element may occur once.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("p")]
        public string P {
            get {
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of polygon primitives. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The material attribute declares a symbol for a material. This symbol is bound to a material at 
        ///the time of instantiation. If the material attribute is not specified then the lighting and 
        ///shading results are application defined. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("material", DataType="NCName")]
        public string Material {
            get {
                return this.materialField;
            }
            set {
                this.materialField = value;
            }
        }
    }
    
    /// <summary>The triangles element provides the information needed to bind vertex attributes together and 
    ///then organize those vertices into individual triangles.	Each triangle described by the mesh has 
    ///three vertices. The first triangle is formed from the first, second, and third vertices. The 
    ///second triangle is formed from the fourth, fifth, and sixth vertices, and so on.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Triangles {
        
        private System.Collections.Generic.List<InputLocalOffset> inputField;
        
        private string pField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string nameField;
        
        private ulong countField;
        
        private string materialField;
        
        /// <summary>The input element may occur any number of times. This input is a local input with the 
        ///offset and set attributes.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocalOffset> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocalOffset>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The triangles element may have any number of p elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("p")]
        public string P {
            get {
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of triangle primitives. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The material attribute declares a symbol for a material. This symbol is bound to a material at 
        ///the time of instantiation. Optional attribute. If the material attribute is not specified then 
        ///the lighting and shading results are application defined.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("material", DataType="NCName")]
        public string Material {
            get {
                return this.materialField;
            }
            set {
                this.materialField = value;
            }
        }
    }
    
    /// <summary>The trifans element provides the information needed to bind vertex attributes together and then 
    ///organize those vertices into connected triangles. Each triangle described by the mesh has three 
    ///vertices. The first triangle is formed from first, second, and third vertices. Each subsequent 
    ///triangle is formed from the current vertex, reusing the first and the previous vertices.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Trifans {
        
        private System.Collections.Generic.List<InputLocalOffset> inputField;
        
        private System.Collections.Generic.List<string> pField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string nameField;
        
        private ulong countField;
        
        private string materialField;
        
        /// <summary>The input element may occur any number of times. This input is a local input with the 
        ///offset and set attributes.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocalOffset> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocalOffset>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The trifans element may have any number of p elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("p")]
        public System.Collections.Generic.List<string> P {
            get {
                if ((this.pField == null)) {
                    this.pField = new System.Collections.Generic.List<string>();
                }
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of triangle fan primitives. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The material attribute declares a symbol for a material. This symbol is bound to a material 
        ///at the time of instantiation. If the material attribute is not specified then the lighting 
        ///and shading results are application defined. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("material", DataType="NCName")]
        public string Material {
            get {
                return this.materialField;
            }
            set {
                this.materialField = value;
            }
        }
    }
    
    /// <summary>The tristrips element provides the information needed to bind vertex attributes together and then 
    ///organize those vertices into connected triangles. Each triangle described by the mesh has three 
    ///vertices. The first triangle is formed from first, second, and third vertices. Each subsequent 
    ///triangle is formed from the current vertex, reusing the previous two vertices.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Tristrips {
        
        private System.Collections.Generic.List<InputLocalOffset> inputField;
        
        private System.Collections.Generic.List<string> pField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string nameField;
        
        private ulong countField;
        
        private string materialField;
        
        /// <summary>The input element may occur any number of times. This input is a local input with the offset 
        ///and set attributes.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocalOffset> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocalOffset>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The tristrips element may have any number of p elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("p")]
        public System.Collections.Generic.List<string> P {
            get {
                if ((this.pField == null)) {
                    this.pField = new System.Collections.Generic.List<string>();
                }
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The count attribute indicates the number of triangle strip primitives. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public ulong Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <summary>The material attribute declares a symbol for a material. This symbol is bound to a material 
        ///at the time of instantiation. If the material attribute is not specified then the lighting 
        ///and shading results are application defined. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("material", DataType="NCName")]
        public string Material {
            get {
                return this.materialField;
            }
            set {
                this.materialField = value;
            }
        }
    }
    
    /// <summary>The mesh element contains vertex and primitive information sufficient to describe basic geometric meshes.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Mesh {
        
        private System.Collections.Generic.List<Source> sourceField;
        
        private Vertices verticesField;
        
        private object[] itemsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>The mesh element must contain one or more source elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public System.Collections.Generic.List<Source> Source {
            get {
                if ((this.sourceField == null)) {
                    this.sourceField = new System.Collections.Generic.List<Source>();
                }
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <summary>The mesh element must contain one vertices element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("vertices")]
        public Vertices Vertices {
            get {
                return this.verticesField;
            }
            set {
                this.verticesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("lines", typeof(Lines))]
        [System.Xml.Serialization.XmlElementAttribute("linestrips", typeof(Linestrips))]
        [System.Xml.Serialization.XmlElementAttribute("polygons", typeof(Polygons))]
        [System.Xml.Serialization.XmlElementAttribute("polylist", typeof(Polylist))]
        [System.Xml.Serialization.XmlElementAttribute("triangles", typeof(Triangles))]
        [System.Xml.Serialization.XmlElementAttribute("trifans", typeof(Trifans))]
        [System.Xml.Serialization.XmlElementAttribute("tristrips", typeof(Tristrips))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>The spline element contains control vertex information sufficient to describe basic splines.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Spline {
        
        private System.Collections.Generic.List<Source> sourceField;
        
        private SplineControlVertices control_verticesField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private bool closedField;
        
        public Spline() {
            this.closedField = false;
        }
        
        /// <summary>The mesh element must contain one or more source elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public System.Collections.Generic.List<Source> Source {
            get {
                if ((this.sourceField == null)) {
                    this.sourceField = new System.Collections.Generic.List<Source>();
                }
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <summary>The control vertices element  must occur  exactly one time. It is used to describe the CVs of the spline.</summary>
        [System.Xml.Serialization.XmlElementAttribute("control_vertices")]
        public SplineControlVertices ControlVertices {
            get {
                return this.control_verticesField;
            }
            set {
                this.control_verticesField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("closed")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Closed {
            get {
                return this.closedField;
            }
            set {
                this.closedField = value;
            }
        }
    }
    
    /// <summary>The control vertices element  must occur  exactly one time. It is used to describe the CVs of the spline.</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SplineControlVertices {
        
        private System.Collections.Generic.List<InputLocal> inputField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>The input element must occur at least one time. These inputs are local inputs.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Collections.Generic.List<InputLocal> Input {
            get {
                if ((this.inputField == null)) {
                    this.inputField = new System.Collections.Generic.List<InputLocal>();
                }
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>The library_images element declares a module of image elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryImages {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Image> imageField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryImages> IDs = new System.Collections.Generic.Dictionary<string, LibraryImages>();
        
        /// <summary>The library_images element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one image element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("image")]
        public System.Collections.Generic.List<Image> Image {
            get {
                if ((this.imageField == null)) {
                    this.imageField = new System.Collections.Generic.List<Image>();
                }
                return this.imageField;
            }
            set {
                this.imageField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The library_lights element declares a module of light elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryLights {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Light> lightField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryLights> IDs = new System.Collections.Generic.Dictionary<string, LibraryLights>();
        
        /// <summary>The library_lights element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one light element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("light")]
        public System.Collections.Generic.List<Light> Light {
            get {
                if ((this.lightField == null)) {
                    this.lightField = new System.Collections.Generic.List<Light>();
                }
                return this.lightField;
            }
            set {
                this.lightField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The light element declares a light source that illuminates the scene.
    ///Light sources have many different properties and radiate light in many different patterns and 
    ///frequencies.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Light {
        
        private Asset assetField;
        
        private LightTechniqueCommon technique_commonField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, Light> IDs = new System.Collections.Generic.Dictionary<string, Light>();
        
        /// <summary>The light element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>The technique_common element specifies the light information for the common profile which all 
        ///COLLADA implementations need to support.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique_common")]
        public LightTechniqueCommon TechniqueCommon {
            get {
                return this.technique_commonField;
            }
            set {
                this.technique_commonField = value;
            }
        }
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The technique_common element specifies the light information for the common profile which all 
    ///COLLADA implementations need to support.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LightTechniqueCommon {
        
        private object itemField;
        
        [System.Xml.Serialization.XmlElementAttribute("ambient", typeof(LightTechniqueCommonAmbient))]
        [System.Xml.Serialization.XmlElementAttribute("directional", typeof(LightTechniqueCommonDirectional))]
        [System.Xml.Serialization.XmlElementAttribute("point", typeof(LightTechniqueCommonPoint))]
        [System.Xml.Serialization.XmlElementAttribute("spot", typeof(LightTechniqueCommonSpot))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <summary>The ambient element declares the parameters required to describe an ambient light source.  
    ///An ambient light is one that lights everything evenly, regardless of location or orientation.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LightTechniqueCommonAmbient {
        
        private TargetableFloat3 colorField;
        
        /// <summary>The color element contains three floating point numbers specifying the color of the light.
        ///The color element must occur exactly once.  
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("color")]
        public TargetableFloat3 Color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
    }
    
    /// <summary>The directional element declares the parameters required to describe a directional light source.  
    ///A directional light is one that lights everything from the same direction, regardless of location.  
    ///The light’s default direction vector in local coordinates is [0,0,-1], pointing down the -Z axis. 
    ///The actual direction of the light is defined by the transform of the node where the light is 
    ///instantiated.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LightTechniqueCommonDirectional {
        
        private TargetableFloat3 colorField;
        
        /// <summary>The color element contains three floating point numbers specifying the color of the light.
        ///The color element must occur exactly once.  
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("color")]
        public TargetableFloat3 Color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
    }
    
    /// <summary>The point element declares the parameters required to describe a point light source.  A point light 
    ///source radiates light in all directions from a known location in space. The intensity of a point 
    ///light source is attenuated as the distance to the light source increases. The position of the light 
    ///is defined by the transform of the node in which it is instantiated.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LightTechniqueCommonPoint {
        
        private TargetableFloat3 colorField;
        
        private TargetableFloat constant_attenuationField;
        
        private TargetableFloat linear_attenuationField;
        
        private TargetableFloat quadratic_attenuationField;
        
        /// <summary>The color element contains three floating point numbers specifying the color of the light.
        ///The color element must occur exactly once.  
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("color")]
        public TargetableFloat3 Color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
        
        /// <summary>The constant_attenuation is used to calculate the total attenuation of this light given a distance. 
        ///The equation used is A = constant_attenuation + Dist*linear_attenuation + Dist^2*quadratic_attenuation. 
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='1.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("constant_attenuation")]
        public TargetableFloat ConstantAttenuation {
            get {
                return this.constant_attenuationField;
            }
            set {
                this.constant_attenuationField = value;
            }
        }
        
        /// <summary>The linear_attenuation is used to calculate the total attenuation of this light given a distance. 
        ///The equation used is A = constant_attenuation + Dist*linear_attenuation + Dist^2*quadratic_attenuation. 
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("linear_attenuation")]
        public TargetableFloat LinearAttenuation {
            get {
                return this.linear_attenuationField;
            }
            set {
                this.linear_attenuationField = value;
            }
        }
        
        /// <summary>The quadratic_attenuation is used to calculate the total attenuation of this light given a distance. 
        ///The equation used is A = constant_attenuation + Dist*linear_attenuation + Dist^2*quadratic_attenuation. 
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("quadratic_attenuation")]
        public TargetableFloat QuadraticAttenuation {
            get {
                return this.quadratic_attenuationField;
            }
            set {
                this.quadratic_attenuationField = value;
            }
        }
    }
    
    /// <summary>The spot element declares the parameters required to describe a spot light source.  A spot light 
    ///source radiates light in one direction from a known location in space. The light radiates from 
    ///the spot light source in a cone shape. The intensity of the light is attenuated as the radiation 
    ///angle increases away from the direction of the light source. The intensity of a spot light source 
    ///is also attenuated as the distance to the light source increases. The position of the light is 
    ///defined by the transform of the node in which it is instantiated. The light’s default direction 
    ///vector in local coordinates is [0,0,-1], pointing down the -Z axis. The actual direction of the 
    ///light is defined by the transform of the node where the light is instantiated.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LightTechniqueCommonSpot {
        
        private TargetableFloat3 colorField;
        
        private TargetableFloat constant_attenuationField;
        
        private TargetableFloat linear_attenuationField;
        
        private TargetableFloat quadratic_attenuationField;
        
        private TargetableFloat falloff_angleField;
        
        private TargetableFloat falloff_exponentField;
        
        /// <summary>The color element contains three floating point numbers specifying the color of the light.
        ///The color element must occur exactly once.  
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("color")]
        public TargetableFloat3 Color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
        
        /// <summary>The constant_attenuation is used to calculate the total attenuation of this light given a distance. 
        ///The equation used is A = constant_attenuation + Dist*linear_attenuation + Dist^2*quadratic_attenuation. 
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='1.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("constant_attenuation")]
        public TargetableFloat ConstantAttenuation {
            get {
                return this.constant_attenuationField;
            }
            set {
                this.constant_attenuationField = value;
            }
        }
        
        /// <summary>The linear_attenuation is used to calculate the total attenuation of this light given a distance. 
        ///The equation used is A = constant_attenuation + Dist*linear_attenuation + Dist^2*quadratic_attenuation. 
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("linear_attenuation")]
        public TargetableFloat LinearAttenuation {
            get {
                return this.linear_attenuationField;
            }
            set {
                this.linear_attenuationField = value;
            }
        }
        
        /// <summary>The quadratic_attenuation is used to calculate the total attenuation of this light given a distance. 
        ///The equation used is A = constant_attenuation + Dist*linear_attenuation + Dist^2*quadratic_attenuation. 
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("quadratic_attenuation")]
        public TargetableFloat QuadraticAttenuation {
            get {
                return this.quadratic_attenuationField;
            }
            set {
                this.quadratic_attenuationField = value;
            }
        }
        
        /// <summary>The falloff_angle is used to specify the amount of attenuation based on the direction of the light.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='180.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("falloff_angle")]
        public TargetableFloat FalloffAngle {
            get {
                return this.falloff_angleField;
            }
            set {
                this.falloff_angleField = value;
            }
        }
        
        /// <summary>The falloff_exponent is used to specify the amount of attenuation based on the direction of the light.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("falloff_exponent")]
        public TargetableFloat FalloffExponent {
            get {
                return this.falloff_exponentField;
            }
            set {
                this.falloff_exponentField = value;
            }
        }
    }
    
    /// <summary>The library_materials element declares a module of material elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryMaterials {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Material> materialField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryMaterials> IDs = new System.Collections.Generic.Dictionary<string, LibraryMaterials>();
        
        /// <summary>The library_materials element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one material element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("material")]
        public System.Collections.Generic.List<Material> Material {
            get {
                if ((this.materialField == null)) {
                    this.materialField = new System.Collections.Generic.List<Material>();
                }
                return this.materialField;
            }
            set {
                this.materialField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>Materials describe the visual appearance of a geometric object.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Material {
        
        private Asset assetField;
        
        private InstanceEffect instance_effectField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, Material> IDs = new System.Collections.Generic.Dictionary<string, Material>();
        
        /// <summary>The material element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>The material must instance an effect.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_effect")]
        public InstanceEffect InstanceEffect {
            get {
                return this.instance_effectField;
            }
            set {
                this.instance_effectField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This value 
        ///must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The instance_effect element declares the instantiation of a COLLADA effect resource.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class InstanceEffect {
        
        private System.Collections.Generic.List<InstanceEffectTechniqueHint> technique_hintField;
        
        private System.Collections.Generic.List<InstanceEffectSetparam> setparamField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string urlField;
        
        private string sidField;
        
        private string nameField;
        
        /// <summary>Add a hint for a platform of which technique to use in this effect.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique_hint")]
        public System.Collections.Generic.List<InstanceEffectTechniqueHint> TechniqueHint {
            get {
                if ((this.technique_hintField == null)) {
                    this.technique_hintField = new System.Collections.Generic.List<InstanceEffectTechniqueHint>();
                }
                return this.technique_hintField;
            }
            set {
                this.technique_hintField = value;
            }
        }
        
        /// <summary>Assigns a new value to a previously defined parameter
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("setparam")]
        public System.Collections.Generic.List<InstanceEffectSetparam> Setparam {
            get {
                if ((this.setparamField == null)) {
                    this.setparamField = new System.Collections.Generic.List<InstanceEffectSetparam>();
                }
                return this.setparamField;
            }
            set {
                this.setparamField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The url attribute refers to resource.  This may refer to a local resource using a relative URL 
        ///fragment identifier that begins with the “#” character. The url attribute may refer to an external 
        ///resource using an absolute or relative URL.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("url", DataType="anyURI")]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>Add a hint for a platform of which technique to use in this effect.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InstanceEffectTechniqueHint {
        
        private string platformField;
        
        private string profileField;
        
        private string refField;
        
        /// <summary>A platform defines a string that specifies which platform this is hint is aimed for.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("platform", DataType="NCName")]
        public string Platform {
            get {
                return this.platformField;
            }
            set {
                this.platformField = value;
            }
        }
        
        /// <summary>A profile defines a string that specifies which API profile this is hint is aimed for.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("profile", DataType="NCName")]
        public string Profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }
        
        /// <summary>A reference to the technique to use for the specified platform.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="NCName")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    /// <summary>Assigns a new value to a previously defined parameter
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InstanceEffectSetparam {
        
        private bool boolField;
        
        private string bool2Field;
        
        private string bool3Field;
        
        private string bool4Field;
        
        private long intField;
        
        private string int2Field;
        
        private string int3Field;
        
        private string int4Field;
        
        private double floatField;
        
        private string float2Field;
        
        private string float3Field;
        
        private string float4Field;
        
        private double float1x1Field;
        
        private string float1x2Field;
        
        private string float1x3Field;
        
        private string float1x4Field;
        
        private string float2x1Field;
        
        private string float2x2Field;
        
        private string float2x3Field;
        
        private string float2x4Field;
        
        private string float3x1Field;
        
        private string float3x2Field;
        
        private string float3x3Field;
        
        private string float3x4Field;
        
        private string float4x1Field;
        
        private string float4x2Field;
        
        private string float4x3Field;
        
        private string float4x4Field;
        
        private FxSurfaceCommon surfaceField;
        
        private FxSampler1DCommon sampler1DField;
        
        private FxSampler2DCommon sampler2DField;
        
        private FxSampler3DCommon sampler3DField;
        
        private FxSamplerCUBECommon samplerCUBEField;
        
        private FxSamplerRECTCommon samplerRECTField;
        
        private FxSamplerDEPTHCommon samplerDEPTHField;
        
        private string enumField;
        
        private string refField;
        
        [System.Xml.Serialization.XmlElementAttribute("bool")]
        public bool Bool {
            get {
                return this.boolField;
            }
            set {
                this.boolField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool2")]
        public string Bool2 {
            get {
                return this.bool2Field;
            }
            set {
                this.bool2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool3")]
        public string Bool3 {
            get {
                return this.bool3Field;
            }
            set {
                this.bool3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bool4")]
        public string Bool4 {
            get {
                return this.bool4Field;
            }
            set {
                this.bool4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int")]
        public long Int {
            get {
                return this.intField;
            }
            set {
                this.intField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int2")]
        public string Int2 {
            get {
                return this.int2Field;
            }
            set {
                this.int2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int3")]
        public string Int3 {
            get {
                return this.int3Field;
            }
            set {
                this.int3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("int4")]
        public string Int4 {
            get {
                return this.int4Field;
            }
            set {
                this.int4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float")]
        public double Float {
            get {
                return this.floatField;
            }
            set {
                this.floatField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2")]
        public string Float2 {
            get {
                return this.float2Field;
            }
            set {
                this.float2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3")]
        public string Float3 {
            get {
                return this.float3Field;
            }
            set {
                this.float3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4")]
        public string Float4 {
            get {
                return this.float4Field;
            }
            set {
                this.float4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float1x1")]
        public double Float1x1 {
            get {
                return this.float1x1Field;
            }
            set {
                this.float1x1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float1x2")]
        public string Float1x2 {
            get {
                return this.float1x2Field;
            }
            set {
                this.float1x2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float1x3")]
        public string Float1x3 {
            get {
                return this.float1x3Field;
            }
            set {
                this.float1x3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float1x4")]
        public string Float1x4 {
            get {
                return this.float1x4Field;
            }
            set {
                this.float1x4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2x1")]
        public string Float2x1 {
            get {
                return this.float2x1Field;
            }
            set {
                this.float2x1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2x2")]
        public string Float2x2 {
            get {
                return this.float2x2Field;
            }
            set {
                this.float2x2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2x3")]
        public string Float2x3 {
            get {
                return this.float2x3Field;
            }
            set {
                this.float2x3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float2x4")]
        public string Float2x4 {
            get {
                return this.float2x4Field;
            }
            set {
                this.float2x4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3x1")]
        public string Float3x1 {
            get {
                return this.float3x1Field;
            }
            set {
                this.float3x1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3x2")]
        public string Float3x2 {
            get {
                return this.float3x2Field;
            }
            set {
                this.float3x2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3x3")]
        public string Float3x3 {
            get {
                return this.float3x3Field;
            }
            set {
                this.float3x3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float3x4")]
        public string Float3x4 {
            get {
                return this.float3x4Field;
            }
            set {
                this.float3x4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4x1")]
        public string Float4x1 {
            get {
                return this.float4x1Field;
            }
            set {
                this.float4x1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4x2")]
        public string Float4x2 {
            get {
                return this.float4x2Field;
            }
            set {
                this.float4x2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4x3")]
        public string Float4x3 {
            get {
                return this.float4x3Field;
            }
            set {
                this.float4x3Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("float4x4")]
        public string Float4x4 {
            get {
                return this.float4x4Field;
            }
            set {
                this.float4x4Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("surface")]
        public FxSurfaceCommon Surface {
            get {
                return this.surfaceField;
            }
            set {
                this.surfaceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("sampler1D")]
        public FxSampler1DCommon Sampler1D {
            get {
                return this.sampler1DField;
            }
            set {
                this.sampler1DField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("sampler2D")]
        public FxSampler2DCommon Sampler2D {
            get {
                return this.sampler2DField;
            }
            set {
                this.sampler2DField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("sampler3D")]
        public FxSampler3DCommon Sampler3D {
            get {
                return this.sampler3DField;
            }
            set {
                this.sampler3DField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("samplerCUBE")]
        public FxSamplerCUBECommon SamplerCUBE {
            get {
                return this.samplerCUBEField;
            }
            set {
                this.samplerCUBEField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("samplerRECT")]
        public FxSamplerRECTCommon SamplerRECT {
            get {
                return this.samplerRECTField;
            }
            set {
                this.samplerRECTField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("samplerDEPTH")]
        public FxSamplerDEPTHCommon SamplerDEPTH {
            get {
                return this.samplerDEPTHField;
            }
            set {
                this.samplerDEPTHField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("enum")]
        public string Enum {
            get {
                return this.enumField;
            }
            set {
                this.enumField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType="token")]
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    /// <summary>The library_nodes element declares a module of node elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryNodes {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Node> nodeField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryNodes> IDs = new System.Collections.Generic.Dictionary<string, LibraryNodes>();
        
        /// <summary>The library_nodes element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one node element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("node")]
        public System.Collections.Generic.List<Node> Node {
            get {
                if ((this.nodeField == null)) {
                    this.nodeField = new System.Collections.Generic.List<Node>();
                }
                return this.nodeField;
            }
            set {
                this.nodeField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>Nodes embody the hierarchical relationship of elements in the scene.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Node {
        
        private Asset assetField;
        
        private object[] itemsField;
        
        private ItemsChoiceType2[] itemsElementNameField;
        
        private System.Collections.Generic.List<InstanceWithExtra> instance_cameraField;
        
        private System.Collections.Generic.List<InstanceController> instance_controllerField;
        
        private System.Collections.Generic.List<InstanceGeometry> instance_geometryField;
        
        private System.Collections.Generic.List<InstanceWithExtra> instance_lightField;
        
        private System.Collections.Generic.List<InstanceWithExtra> instance_nodeField;
        
        private System.Collections.Generic.List<Node> node1Field;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        private string sidField;
        
        private NodeType typeField;
        
        private System.Collections.Generic.List<string> layerField;
        
        public static System.Collections.Generic.Dictionary<string, Node> IDs = new System.Collections.Generic.Dictionary<string, Node>();
        
        public Node() {
            this.typeField = NodeType.NODE;
        }
        
        /// <summary>The node element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("lookat", typeof(Lookat))]
        [System.Xml.Serialization.XmlElementAttribute("matrix", typeof(Matrix))]
        [System.Xml.Serialization.XmlElementAttribute("rotate", typeof(Rotate))]
        [System.Xml.Serialization.XmlElementAttribute("scale", typeof(TargetableFloat3))]
        [System.Xml.Serialization.XmlElementAttribute("skew", typeof(Skew))]
        [System.Xml.Serialization.XmlElementAttribute("translate", typeof(TargetableFloat3))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <summary>The node element may instance any number of camera objects.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_camera")]
        public System.Collections.Generic.List<InstanceWithExtra> InstanceCamera {
            get {
                if ((this.instance_cameraField == null)) {
                    this.instance_cameraField = new System.Collections.Generic.List<InstanceWithExtra>();
                }
                return this.instance_cameraField;
            }
            set {
                this.instance_cameraField = value;
            }
        }
        
        /// <summary>The node element may instance any number of controller objects.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_controller")]
        public System.Collections.Generic.List<InstanceController> InstanceController {
            get {
                if ((this.instance_controllerField == null)) {
                    this.instance_controllerField = new System.Collections.Generic.List<InstanceController>();
                }
                return this.instance_controllerField;
            }
            set {
                this.instance_controllerField = value;
            }
        }
        
        /// <summary>The node element may instance any number of geometry objects.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_geometry")]
        public System.Collections.Generic.List<InstanceGeometry> InstanceGeometry {
            get {
                if ((this.instance_geometryField == null)) {
                    this.instance_geometryField = new System.Collections.Generic.List<InstanceGeometry>();
                }
                return this.instance_geometryField;
            }
            set {
                this.instance_geometryField = value;
            }
        }
        
        /// <summary>The node element may instance any number of light objects.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_light")]
        public System.Collections.Generic.List<InstanceWithExtra> InstanceLight {
            get {
                if ((this.instance_lightField == null)) {
                    this.instance_lightField = new System.Collections.Generic.List<InstanceWithExtra>();
                }
                return this.instance_lightField;
            }
            set {
                this.instance_lightField = value;
            }
        }
        
        /// <summary>The node element may instance any number of node elements or hierarchies objects.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_node")]
        public System.Collections.Generic.List<InstanceWithExtra> InstanceNode {
            get {
                if ((this.instance_nodeField == null)) {
                    this.instance_nodeField = new System.Collections.Generic.List<InstanceWithExtra>();
                }
                return this.instance_nodeField;
            }
            set {
                this.instance_nodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("node")]
        public System.Collections.Generic.List<Node> Node1 {
            get {
                if ((this.node1Field == null)) {
                    this.node1Field = new System.Collections.Generic.List<Node>();
                }
                return this.node1Field;
            }
            set {
                this.node1Field = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The type attribute indicates the type of the node element. The default value is “NODE”. 
        ///Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        [System.ComponentModel.DefaultValueAttribute(NodeType.NODE)]
        public NodeType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <summary>The layer attribute indicates the names of the layers to which this node belongs.  For example, 
        ///a value of “foreground glowing” indicates that this node belongs to both the ‘foreground’ layer 
        ///and the ‘glowing’ layer.  The default value is empty, indicating that the node doesn’t belong to 
        ///any layer.  Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("layer", DataType="Name")]
        public System.Collections.Generic.List<string> Layer {
            get {
                if ((this.layerField == null)) {
                    this.layerField = new System.Collections.Generic.List<string>();
                }
                return this.layerField;
            }
            set {
                this.layerField = value;
            }
        }
    }
    
    /// <summary>The lookat element contains a position and orientation transformation suitable for aiming a camera.
    ///The lookat element contains three mathematical vectors within it that describe: 
    ///1.	The position of the object;
    ///2.	The position of the interest point;
    ///3.	The direction that points up.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Lookat {
        
        private string sidField;
        
        private string textField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <summary>Matrix transformations embody mathematical changes to points within a coordinate systems or the 
    ///coordinate system itself. The matrix element contains a 4-by-4 matrix of floating-point values.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Matrix {
        
        private string sidField;
        
        private string textField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <summary>The rotate element contains an angle and a mathematical vector that represents the axis of rotation.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Rotate {
        
        private string sidField;
        
        private string textField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <summary>The skew element contains an angle and two mathematical vectors that represent the axis of 
    ///rotation and the axis of translation.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Skew {
        
        private string sidField;
        
        private string textField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IncludeInSchema=false)]
    public enum ItemsChoiceType2 {
        
        lookat,
        
        matrix,
        
        rotate,
        
        scale,
        
        skew,
        
        translate,
    }
    
    /// <summary>The instance_controller element declares the instantiation of a COLLADA controller resource.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class InstanceController {
        
        private System.Collections.Generic.List<string> skeletonField;
        
        private BindMaterial bind_materialField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string urlField;
        
        private string sidField;
        
        private string nameField;
        
        /// <summary>The skeleton element is used to indicate where a skin controller is to start to search for 
        ///the joint nodes it needs.  This element is meaningless for morph controllers.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("skeleton", DataType="anyURI")]
        public System.Collections.Generic.List<string> Skeleton {
            get {
                if ((this.skeletonField == null)) {
                    this.skeletonField = new System.Collections.Generic.List<string>();
                }
                return this.skeletonField;
            }
            set {
                this.skeletonField = value;
            }
        }
        
        /// <summary>Bind a specific material to a piece of geometry, binding varying and uniform parameters at the 
        ///same time.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("bind_material")]
        public BindMaterial BindMaterial {
            get {
                return this.bind_materialField;
            }
            set {
                this.bind_materialField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The url attribute refers to resource. This may refer to a local resource using a relative 
        ///URL fragment identifier that begins with the “#” character. The url attribute may refer to an 
        ///external resource using an absolute or relative URL.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("url", DataType="anyURI")]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>Bind a specific material to a piece of geometry, binding varying and uniform parameters at the 
    ///same time.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class BindMaterial {
        
        private System.Collections.Generic.List<Param> paramField;
        
        private System.Collections.Generic.List<InstanceMaterial> technique_commonField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>The bind_material element may contain any number of param elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("param")]
        public System.Collections.Generic.List<Param> Param {
            get {
                if ((this.paramField == null)) {
                    this.paramField = new System.Collections.Generic.List<Param>();
                }
                return this.paramField;
            }
            set {
                this.paramField = value;
            }
        }
        
        /// <summary>The technique_common element specifies the bind_material information for the common 
        ///profile which all COLLADA implementations need to support.
        ///</summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("instance_material", IsNullable=false)]
        public System.Collections.Generic.List<InstanceMaterial> technique_common {
            get {
                if ((this.technique_commonField == null)) {
                    this.technique_commonField = new System.Collections.Generic.List<InstanceMaterial>();
                }
                return this.technique_commonField;
            }
            set {
                this.technique_commonField = value;
            }
        }
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>The instance_geometry element declares the instantiation of a COLLADA geometry resource.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class InstanceGeometry {
        
        private BindMaterial bind_materialField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string urlField;
        
        private string sidField;
        
        private string nameField;
        
        /// <summary>Bind a specific material to a piece of geometry, binding varying and uniform parameters at the 
        ///same time.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("bind_material")]
        public BindMaterial BindMaterial {
            get {
                return this.bind_materialField;
            }
            set {
                this.bind_materialField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The url attribute refers to resource.  This may refer to a local resource using a relative URL 
        ///fragment identifier that begins with the “#” character. The url attribute may refer to an external 
        ///resource using an absolute or relative URL.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("url", DataType="anyURI")]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum NodeType {
        
        JOINT,
        
        NODE,
    }
    
    /// <summary>The library_physics_materials element declares a module of physics_material elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryPhysicsMaterials {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<PhysicsMaterial> physics_materialField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryPhysicsMaterials> IDs = new System.Collections.Generic.Dictionary<string, LibraryPhysicsMaterials>();
        
        /// <summary>The library_physics_materials element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one physics_material element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("physics_material")]
        public System.Collections.Generic.List<PhysicsMaterial> PhysicsMaterial {
            get {
                if ((this.physics_materialField == null)) {
                    this.physics_materialField = new System.Collections.Generic.List<PhysicsMaterial>();
                }
                return this.physics_materialField;
            }
            set {
                this.physics_materialField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>This element defines the physical properties of an object. It contains a technique/profile with 
    ///parameters. The COMMON profile defines the built-in names, such as static_friction.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class PhysicsMaterial {
        
        private Asset assetField;
        
        private PhysicsMaterialTechniqueCommon technique_commonField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, PhysicsMaterial> IDs = new System.Collections.Generic.Dictionary<string, PhysicsMaterial>();
        
        /// <summary>The physics_material element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>The technique_common element specifies the physics_material information for the common profile 
        ///which all COLLADA implementations need to support.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique_common")]
        public PhysicsMaterialTechniqueCommon TechniqueCommon {
            get {
                return this.technique_commonField;
            }
            set {
                this.technique_commonField = value;
            }
        }
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The technique_common element specifies the physics_material information for the common profile 
    ///which all COLLADA implementations need to support.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PhysicsMaterialTechniqueCommon {
        
        private TargetableFloat dynamic_frictionField;
        
        private TargetableFloat restitutionField;
        
        private TargetableFloat static_frictionField;
        
        /// <summary>Dynamic friction coefficient
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("dynamic_friction")]
        public TargetableFloat DynamicFriction {
            get {
                return this.dynamic_frictionField;
            }
            set {
                this.dynamic_frictionField = value;
            }
        }
        
        /// <summary>The proportion of the kinetic energy preserved in the impact (typically ranges from 0.0 to 1.0)
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("restitution")]
        public TargetableFloat Restitution {
            get {
                return this.restitutionField;
            }
            set {
                this.restitutionField = value;
            }
        }
        
        /// <summary>Static friction coefficient
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("static_friction")]
        public TargetableFloat StaticFriction {
            get {
                return this.static_frictionField;
            }
            set {
                this.static_frictionField = value;
            }
        }
    }
    
    /// <summary>The library_physics_models element declares a module of physics_model elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryPhysicsModels {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<PhysicsModel> physics_modelField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryPhysicsModels> IDs = new System.Collections.Generic.Dictionary<string, LibraryPhysicsModels>();
        
        /// <summary>The library_physics_models element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one physics_model element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("physics_model")]
        public System.Collections.Generic.List<PhysicsModel> PhysicsModel {
            get {
                if ((this.physics_modelField == null)) {
                    this.physics_modelField = new System.Collections.Generic.List<PhysicsModel>();
                }
                return this.physics_modelField;
            }
            set {
                this.physics_modelField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>This element allows for building complex combinations of rigid-bodies and constraints that 
    ///may be instantiated multiple times.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class PhysicsModel {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<RigidBody> rigid_bodyField;
        
        private System.Collections.Generic.List<RigidConstraint> rigid_constraintField;
        
        private System.Collections.Generic.List<InstancePhysicsModel> instance_physics_modelField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, PhysicsModel> IDs = new System.Collections.Generic.Dictionary<string, PhysicsModel>();
        
        /// <summary>The physics_model element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>The physics_model may define any number of rigid_body elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("rigid_body")]
        public System.Collections.Generic.List<RigidBody> RigidBody {
            get {
                if ((this.rigid_bodyField == null)) {
                    this.rigid_bodyField = new System.Collections.Generic.List<RigidBody>();
                }
                return this.rigid_bodyField;
            }
            set {
                this.rigid_bodyField = value;
            }
        }
        
        /// <summary>The physics_model may define any number of rigid_constraint elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("rigid_constraint")]
        public System.Collections.Generic.List<RigidConstraint> RigidConstraint {
            get {
                if ((this.rigid_constraintField == null)) {
                    this.rigid_constraintField = new System.Collections.Generic.List<RigidConstraint>();
                }
                return this.rigid_constraintField;
            }
            set {
                this.rigid_constraintField = value;
            }
        }
        
        /// <summary>The physics_model may instance any number of other physics_model elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_physics_model")]
        public System.Collections.Generic.List<InstancePhysicsModel> InstancePhysicsModel {
            get {
                if ((this.instance_physics_modelField == null)) {
                    this.instance_physics_modelField = new System.Collections.Generic.List<InstancePhysicsModel>();
                }
                return this.instance_physics_modelField;
            }
            set {
                this.instance_physics_modelField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>This element allows for describing simulated bodies that do not deform. These bodies may or may 
    ///not be connected by constraints (hinge, ball-joint etc.).  Rigid-bodies, constraints etc. are 
    ///encapsulated in physics_model elements to allow for instantiating complex models.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class RigidBody {
        
        private RigidBodyTechniqueCommon technique_commonField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string sidField;
        
        private string nameField;
        
        /// <summary>The technique_common element specifies the rigid_body information for the common profile which all 
        ///COLLADA implementations need to support.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique_common")]
        public RigidBodyTechniqueCommon TechniqueCommon {
            get {
                return this.technique_commonField;
            }
            set {
                this.technique_commonField = value;
            }
        }
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The technique_common element specifies the rigid_body information for the common profile which all 
    ///COLLADA implementations need to support.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidBodyTechniqueCommon {
        
        private RigidBodyTechniqueCommonDynamic dynamicField;
        
        private TargetableFloat massField;
        
        private System.Collections.Generic.List<object> mass_frameField;
        
        private TargetableFloat3 inertiaField;
        
        private object itemField;
        
        private System.Collections.Generic.List<RigidBodyTechniqueCommonShape> shapeField;
        
        /// <summary>If false, the rigid_body is not moveable
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("dynamic")]
        public RigidBodyTechniqueCommonDynamic Dynamic {
            get {
                return this.dynamicField;
            }
            set {
                this.dynamicField = value;
            }
        }
        
        /// <summary>The total mass of the rigid-body
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("mass")]
        public TargetableFloat Mass {
            get {
                return this.massField;
            }
            set {
                this.massField = value;
            }
        }
        
        /// <summary>Defines the center and orientation of mass of the rigid-body relative to the local origin of the 
        ///“root” shape.This makes the off-diagonal elements of the inertia tensor (products of inertia) all 
        ///0 and allows us to just store the diagonal elements (moments of inertia).
        ///</summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("rotate", typeof(Rotate), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("translate", typeof(TargetableFloat3), IsNullable=false)]
        public System.Collections.Generic.List<object> mass_frame {
            get {
                if ((this.mass_frameField == null)) {
                    this.mass_frameField = new System.Collections.Generic.List<object>();
                }
                return this.mass_frameField;
            }
            set {
                this.mass_frameField = value;
            }
        }
        
        /// <summary>float3 – The diagonal elements of the inertia tensor (moments of inertia), which is represented 
        ///in the local frame of the center of mass. See above.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("inertia")]
        public TargetableFloat3 Inertia {
            get {
                return this.inertiaField;
            }
            set {
                this.inertiaField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("instance_physics_material", typeof(InstanceWithExtra))]
        [System.Xml.Serialization.XmlElementAttribute("physics_material", typeof(PhysicsMaterial))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <summary>This element allows for describing components of a rigid_body.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("shape")]
        public System.Collections.Generic.List<RigidBodyTechniqueCommonShape> Shape {
            get {
                if ((this.shapeField == null)) {
                    this.shapeField = new System.Collections.Generic.List<RigidBodyTechniqueCommonShape>();
                }
                return this.shapeField;
            }
            set {
                this.shapeField = value;
            }
        }
    }
    
    /// <summary>If false, the rigid_body is not moveable
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidBodyTechniqueCommonDynamic {
        
        private string sidField;
        
        private bool valueField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <summary>This element allows for describing components of a rigid_body.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidBodyTechniqueCommonShape {
        
        private RigidBodyTechniqueCommonShapeHollow hollowField;
        
        private TargetableFloat massField;
        
        private TargetableFloat densityField;
        
        private object itemField;
        
        private object item1Field;
        
        private object[] itemsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>If true, the mass is distributed along the surface of the shape
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("hollow")]
        public RigidBodyTechniqueCommonShapeHollow Hollow {
            get {
                return this.hollowField;
            }
            set {
                this.hollowField = value;
            }
        }
        
        /// <summary>The mass of the shape.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("mass")]
        public TargetableFloat Mass {
            get {
                return this.massField;
            }
            set {
                this.massField = value;
            }
        }
        
        /// <summary>The density of the shape.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("density")]
        public TargetableFloat Density {
            get {
                return this.densityField;
            }
            set {
                this.densityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("instance_physics_material", typeof(InstanceWithExtra))]
        [System.Xml.Serialization.XmlElementAttribute("physics_material", typeof(PhysicsMaterial))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("box", typeof(Box))]
        [System.Xml.Serialization.XmlElementAttribute("capsule", typeof(Capsule))]
        [System.Xml.Serialization.XmlElementAttribute("cylinder", typeof(Cylinder))]
        [System.Xml.Serialization.XmlElementAttribute("instance_geometry", typeof(InstanceGeometry))]
        [System.Xml.Serialization.XmlElementAttribute("plane", typeof(Plane))]
        [System.Xml.Serialization.XmlElementAttribute("sphere", typeof(Sphere))]
        [System.Xml.Serialization.XmlElementAttribute("tapered_capsule", typeof(TaperedCapsule))]
        [System.Xml.Serialization.XmlElementAttribute("tapered_cylinder", typeof(TaperedCylinder))]
        public object Item1 {
            get {
                return this.item1Field;
            }
            set {
                this.item1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("rotate", typeof(Rotate))]
        [System.Xml.Serialization.XmlElementAttribute("translate", typeof(TargetableFloat3))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>If true, the mass is distributed along the surface of the shape
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidBodyTechniqueCommonShapeHollow {
        
        private string sidField;
        
        private bool valueField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <summary>An axis-aligned, centered box primitive.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Box {
        
        private string half_extentsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>3 float values that represent the extents of the box
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("half_extents")]
        public string HalfExtents {
            get {
                return this.half_extentsField;
            }
            set {
                this.half_extentsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>A capsule primitive that is centered on and aligned with the local Y axis.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Capsule {
        
        private double heightField;
        
        private string radiusField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>A float value that represents the length of the line segment connecting the centers 
        ///of the capping hemispheres.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("height")]
        public double Height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <summary>Two float values that represent the radii of the capsule (it may be elliptical)
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("radius")]
        public string Radius {
            get {
                return this.radiusField;
            }
            set {
                this.radiusField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>A cylinder primitive that is centered on, and aligned with. the local Y axis.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Cylinder {
        
        private double heightField;
        
        private string radiusField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>A float value that represents the length of the cylinder along the Y axis.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("height")]
        public double Height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <summary>float2 values that represent the radii of the cylinder.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("radius")]
        public string Radius {
            get {
                return this.radiusField;
            }
            set {
                this.radiusField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>An infinite plane primitive.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Plane {
        
        private string equationField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>4 float values that represent the coefficients for the plane’s equation:    Ax + By + Cz + D = 0
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("equation")]
        public string Equation {
            get {
                return this.equationField;
            }
            set {
                this.equationField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>A centered sphere primitive.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Sphere {
        
        private double radiusField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>A float value that represents the radius of the sphere
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("radius")]
        public double Radius {
            get {
                return this.radiusField;
            }
            set {
                this.radiusField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>A tapered capsule primitive that is centered on, and aligned with, the local Y axis.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class TaperedCapsule {
        
        private double heightField;
        
        private string radius1Field;
        
        private string radius2Field;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>A float value that represents the length of the line segment connecting the centers of the 
        ///capping hemispheres.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("height")]
        public double Height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <summary>Two float values that represent the radii of the tapered capsule at the positive (height/2) 
        ///Y value.Both ends of the tapered capsule may be elliptical.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("radius1")]
        public string Radius1 {
            get {
                return this.radius1Field;
            }
            set {
                this.radius1Field = value;
            }
        }
        
        /// <summary>Two float values that represent the radii of the tapered capsule at the negative (height/2) 
        ///Y value.Both ends of the tapered capsule may be elliptical.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("radius2")]
        public string Radius2 {
            get {
                return this.radius2Field;
            }
            set {
                this.radius2Field = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>A tapered cylinder primitive that is centered on and aligned with the local Y axis.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class TaperedCylinder {
        
        private double heightField;
        
        private string radius1Field;
        
        private string radius2Field;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>A float value that represents the length of the cylinder along the Y axis.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("height")]
        public double Height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <summary>Two float values that represent the radii of the tapered cylinder at the positive (height/2) 
        ///Y value. Both ends of the tapered cylinder may be elliptical.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("radius1")]
        public string Radius1 {
            get {
                return this.radius1Field;
            }
            set {
                this.radius1Field = value;
            }
        }
        
        /// <summary>Two float values that represent the radii of the tapered cylinder at the negative (height/2) 
        ///Y value.Both ends of the tapered cylinder may be elliptical.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("radius2")]
        public string Radius2 {
            get {
                return this.radius2Field;
            }
            set {
                this.radius2Field = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    /// <summary>This element allows for connecting components, such as rigid_body into complex physics models 
    ///with moveable parts.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class RigidConstraint {
        
        private RigidConstraintRefAttachment ref_attachmentField;
        
        private RigidConstraintAttachment attachmentField;
        
        private RigidConstraintTechniqueCommon technique_commonField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string sidField;
        
        private string nameField;
        
        /// <summary>Defines the attachment (to a rigid_body or a node) to be used as the reference-frame.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("ref_attachment")]
        public RigidConstraintRefAttachment RefAttachment {
            get {
                return this.ref_attachmentField;
            }
            set {
                this.ref_attachmentField = value;
            }
        }
        
        /// <summary>Defines an attachment to a rigid-body or a node.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("attachment")]
        public RigidConstraintAttachment Attachment {
            get {
                return this.attachmentField;
            }
            set {
                this.attachmentField = value;
            }
        }
        
        /// <summary>The technique_common element specifies the rigid_constraint information for the common profile 
        ///which all COLLADA implementations need to support.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique_common")]
        public RigidConstraintTechniqueCommon TechniqueCommon {
            get {
                return this.technique_commonField;
            }
            set {
                this.technique_commonField = value;
            }
        }
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>Defines the attachment (to a rigid_body or a node) to be used as the reference-frame.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintRefAttachment {
        
        private object[] itemsField;
        
        private string rigid_bodyField;
        
        [System.Xml.Serialization.XmlElementAttribute("extra", typeof(Extra))]
        [System.Xml.Serialization.XmlElementAttribute("rotate", typeof(Rotate))]
        [System.Xml.Serialization.XmlElementAttribute("translate", typeof(TargetableFloat3))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The “rigid_body” attribute is a relative reference to a rigid-body within the same 
        ///physics_model.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("rigid_body", DataType="anyURI")]
        public string RigidBody {
            get {
                return this.rigid_bodyField;
            }
            set {
                this.rigid_bodyField = value;
            }
        }
    }
    
    /// <summary>Defines an attachment to a rigid-body or a node.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintAttachment {
        
        private object[] itemsField;
        
        private string rigid_bodyField;
        
        [System.Xml.Serialization.XmlElementAttribute("extra", typeof(Extra))]
        [System.Xml.Serialization.XmlElementAttribute("rotate", typeof(Rotate))]
        [System.Xml.Serialization.XmlElementAttribute("translate", typeof(TargetableFloat3))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The “rigid_body” attribute is a relative reference to a rigid-body within the same physics_model.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("rigid_body", DataType="anyURI")]
        public string RigidBody {
            get {
                return this.rigid_bodyField;
            }
            set {
                this.rigid_bodyField = value;
            }
        }
    }
    
    /// <summary>The technique_common element specifies the rigid_constraint information for the common profile 
    ///which all COLLADA implementations need to support.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintTechniqueCommon {
        
        private RigidConstraintTechniqueCommonEnabled enabledField;
        
        private RigidConstraintTechniqueCommonInterpenetrate interpenetrateField;
        
        private RigidConstraintTechniqueCommonLimits limitsField;
        
        private RigidConstraintTechniqueCommonSpring springField;
        
        /// <summary>If false, the constraint doesn’t exert any force or influence on the rigid bodies.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type rigid_constraintTechnique_commonEnabled is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='true' attribute.
        [System.Xml.Serialization.XmlElementAttribute("enabled")]
        public RigidConstraintTechniqueCommonEnabled Enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        
        /// <summary>Indicates whether the attached rigid bodies may inter-penetrate.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type rigid_constraintTechnique_commonInterpenetrate is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        [System.Xml.Serialization.XmlElementAttribute("interpenetrate")]
        public RigidConstraintTechniqueCommonInterpenetrate Interpenetrate {
            get {
                return this.interpenetrateField;
            }
            set {
                this.interpenetrateField = value;
            }
        }
        
        /// <summary>The limits element provides a flexible way to specify the constraint limits (degrees of freedom 
        ///and ranges).
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("limits")]
        public RigidConstraintTechniqueCommonLimits Limits {
            get {
                return this.limitsField;
            }
            set {
                this.limitsField = value;
            }
        }
        
        /// <summary>Spring, based on distance (“LINEAR”) or angle (“ANGULAR”). 
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("spring")]
        public RigidConstraintTechniqueCommonSpring Spring {
            get {
                return this.springField;
            }
            set {
                this.springField = value;
            }
        }
    }
    
    /// <summary>If false, the constraint doesn’t exert any force or influence on the rigid bodies.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintTechniqueCommonEnabled {
        
        private string sidField;
        
        private bool valueField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <summary>Indicates whether the attached rigid bodies may inter-penetrate.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintTechniqueCommonInterpenetrate {
        
        private string sidField;
        
        private bool valueField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <summary>The limits element provides a flexible way to specify the constraint limits (degrees of freedom 
    ///and ranges).
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintTechniqueCommonLimits {
        
        private RigidConstraintTechniqueCommonLimitsSwingConeAndTwist swing_cone_and_twistField;
        
        private RigidConstraintTechniqueCommonLimitsLinear linearField;
        
        /// <summary>The swing_cone_and_twist element describes the angular limits along each rotation axis in degrees.
        ///The the X and Y limits describe a “swing cone” and the Z limits describe the “twist angle” range 
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("swing_cone_and_twist")]
        public RigidConstraintTechniqueCommonLimitsSwingConeAndTwist SwingConeAndTwist {
            get {
                return this.swing_cone_and_twistField;
            }
            set {
                this.swing_cone_and_twistField = value;
            }
        }
        
        /// <summary>The linear element describes linear (translational) limits along each axis.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("linear")]
        public RigidConstraintTechniqueCommonLimitsLinear Linear {
            get {
                return this.linearField;
            }
            set {
                this.linearField = value;
            }
        }
    }
    
    /// <summary>The swing_cone_and_twist element describes the angular limits along each rotation axis in degrees.
    ///The the X and Y limits describe a “swing cone” and the Z limits describe the “twist angle” range 
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintTechniqueCommonLimitsSwingConeAndTwist {
        
        private TargetableFloat3 minField;
        
        private TargetableFloat3 maxField;
        
        /// <summary>The minimum values for the limit.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat3 is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0 0.0 0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("min")]
        public TargetableFloat3 Min {
            get {
                return this.minField;
            }
            set {
                this.minField = value;
            }
        }
        
        /// <summary>The maximum values for the limit.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat3 is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0 0.0 0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("max")]
        public TargetableFloat3 Max {
            get {
                return this.maxField;
            }
            set {
                this.maxField = value;
            }
        }
    }
    
    /// <summary>The linear element describes linear (translational) limits along each axis.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintTechniqueCommonLimitsLinear {
        
        private TargetableFloat3 minField;
        
        private TargetableFloat3 maxField;
        
        /// <summary>The minimum values for the limit.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat3 is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0 0.0 0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("min")]
        public TargetableFloat3 Min {
            get {
                return this.minField;
            }
            set {
                this.minField = value;
            }
        }
        
        /// <summary>The maximum values for the limit.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat3 is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0 0.0 0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("max")]
        public TargetableFloat3 Max {
            get {
                return this.maxField;
            }
            set {
                this.maxField = value;
            }
        }
    }
    
    /// <summary>Spring, based on distance (“LINEAR”) or angle (“ANGULAR”). 
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintTechniqueCommonSpring {
        
        private RigidConstraintTechniqueCommonSpringAngular angularField;
        
        private RigidConstraintTechniqueCommonSpringLinear linearField;
        
        /// <summary>The angular spring properties.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("angular")]
        public RigidConstraintTechniqueCommonSpringAngular Angular {
            get {
                return this.angularField;
            }
            set {
                this.angularField = value;
            }
        }
        
        /// <summary>The linear spring properties.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("linear")]
        public RigidConstraintTechniqueCommonSpringLinear Linear {
            get {
                return this.linearField;
            }
            set {
                this.linearField = value;
            }
        }
    }
    
    /// <summary>The angular spring properties.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintTechniqueCommonSpringAngular {
        
        private TargetableFloat stiffnessField;
        
        private TargetableFloat dampingField;
        
        private TargetableFloat target_valueField;
        
        /// <summary>The stiffness (also called spring coefficient) has units of force/angle in degrees. 
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='1.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("stiffness")]
        public TargetableFloat Stiffness {
            get {
                return this.stiffnessField;
            }
            set {
                this.stiffnessField = value;
            }
        }
        
        /// <summary>The spring damping coefficient.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("damping")]
        public TargetableFloat Damping {
            get {
                return this.dampingField;
            }
            set {
                this.dampingField = value;
            }
        }
        
        /// <summary>The spring's target or resting distance.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("target_value")]
        public TargetableFloat TargetValue {
            get {
                return this.target_valueField;
            }
            set {
                this.target_valueField = value;
            }
        }
    }
    
    /// <summary>The linear spring properties.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RigidConstraintTechniqueCommonSpringLinear {
        
        private TargetableFloat stiffnessField;
        
        private TargetableFloat dampingField;
        
        private TargetableFloat target_valueField;
        
        /// <summary>The stiffness (also called spring coefficient) has units of force/distance. 
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='1.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("stiffness")]
        public TargetableFloat Stiffness {
            get {
                return this.stiffnessField;
            }
            set {
                this.stiffnessField = value;
            }
        }
        
        /// <summary>The spring damping coefficient.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("damping")]
        public TargetableFloat Damping {
            get {
                return this.dampingField;
            }
            set {
                this.dampingField = value;
            }
        }
        
        /// <summary>The spring's target or resting distance.
        ///</summary>
        // CODEGEN Warning: DefaultValue attribute on members of type TargetableFloat is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0.0' attribute.
        [System.Xml.Serialization.XmlElementAttribute("target_value")]
        public TargetableFloat TargetValue {
            get {
                return this.target_valueField;
            }
            set {
                this.target_valueField = value;
            }
        }
    }
    
    /// <summary>This element allows instancing physics model within another physics model, or in a physics scene.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class InstancePhysicsModel {
        
        private System.Collections.Generic.List<InstanceWithExtra> instance_force_fieldField;
        
        private System.Collections.Generic.List<InstanceRigidBody> instance_rigid_bodyField;
        
        private System.Collections.Generic.List<InstanceRigidConstraint> instance_rigid_constraintField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string urlField;
        
        private string sidField;
        
        private string nameField;
        
        private string parentField;
        
        /// <summary>The instance_physics_model element may instance any number of force_field elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_force_field")]
        public System.Collections.Generic.List<InstanceWithExtra> InstanceForceField {
            get {
                if ((this.instance_force_fieldField == null)) {
                    this.instance_force_fieldField = new System.Collections.Generic.List<InstanceWithExtra>();
                }
                return this.instance_force_fieldField;
            }
            set {
                this.instance_force_fieldField = value;
            }
        }
        
        /// <summary>The instance_physics_model element may instance any number of rigid_body elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_rigid_body")]
        public System.Collections.Generic.List<InstanceRigidBody> InstanceRigidBody {
            get {
                if ((this.instance_rigid_bodyField == null)) {
                    this.instance_rigid_bodyField = new System.Collections.Generic.List<InstanceRigidBody>();
                }
                return this.instance_rigid_bodyField;
            }
            set {
                this.instance_rigid_bodyField = value;
            }
        }
        
        /// <summary>The instance_physics_model element may instance any number of rigid_constraint elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_rigid_constraint")]
        public System.Collections.Generic.List<InstanceRigidConstraint> InstanceRigidConstraint {
            get {
                if ((this.instance_rigid_constraintField == null)) {
                    this.instance_rigid_constraintField = new System.Collections.Generic.List<InstanceRigidConstraint>();
                }
                return this.instance_rigid_constraintField;
            }
            set {
                this.instance_rigid_constraintField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The url attribute refers to resource.  This may refer to a local resource using a relative URL 
        ///fragment identifier that begins with the “#” character. The url attribute may refer to an external 
        ///resource using an absolute or relative URL.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("url", DataType="anyURI")]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The parent attribute points to the id of a node in the visual scene. This allows a physics model 
        ///to be instantiated under a specific transform node, which will dictate the initial position and 
        ///orientation, and could be animated to influence kinematic rigid bodies.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("parent", DataType="anyURI")]
        public string Parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }
    }
    
    /// <summary>This element allows instancing a rigid_body within an instance_physics_model. 
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class InstanceRigidBody {
        
        private InstanceRigidBodyTechniqueCommon technique_commonField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string bodyField;
        
        private string sidField;
        
        private string nameField;
        
        private string targetField;
        
        /// <summary>The technique_common element specifies the instance_rigid_body information for the common 
        ///profile which all COLLADA implementations need to support.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique_common")]
        public InstanceRigidBodyTechniqueCommon TechniqueCommon {
            get {
                return this.technique_commonField;
            }
            set {
                this.technique_commonField = value;
            }
        }
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The body attribute indicates which rigid_body to instantiate. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("body", DataType="NCName")]
        public string Body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <summary>The target attribute indicates which node is influenced by this rigid_body instance. 
        ///Required attribute
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("target", DataType="anyURI")]
        public string Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
    }
    
    /// <summary>The technique_common element specifies the instance_rigid_body information for the common 
    ///profile which all COLLADA implementations need to support.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InstanceRigidBodyTechniqueCommon {
        
        private string angular_velocityField;
        
        private string velocityField;
        
        private InstanceRigidBodyTechniqueCommonDynamic dynamicField;
        
        private TargetableFloat massField;
        
        private System.Collections.Generic.List<object> mass_frameField;
        
        private TargetableFloat3 inertiaField;
        
        private object itemField;
        
        private System.Collections.Generic.List<InstanceRigidBodyTechniqueCommonShape> shapeField;
        
        public InstanceRigidBodyTechniqueCommon() {
            this.angular_velocityField = "0.0 0.0 0.0";
            this.velocityField = "0.0 0.0 0.0";
        }
        
        /// <summary>Specifies the initial angular velocity of the rigid_body instance in degrees per second 
        ///around each axis, in the form of an X-Y-Z Euler rotation.
        ///</summary>
        [System.ComponentModel.DefaultValueAttribute("0.0 0.0 0.0")]
        public string angular_velocity {
            get {
                return this.angular_velocityField;
            }
            set {
                this.angular_velocityField = value;
            }
        }
        
        /// <summary>Specifies the initial linear velocity of the rigid_body instance.
        ///</summary>
        [System.ComponentModel.DefaultValueAttribute("0.0 0.0 0.0")]
        public string velocity {
            get {
                return this.velocityField;
            }
            set {
                this.velocityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("dynamic")]
        public InstanceRigidBodyTechniqueCommonDynamic Dynamic {
            get {
                return this.dynamicField;
            }
            set {
                this.dynamicField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("mass")]
        public TargetableFloat Mass {
            get {
                return this.massField;
            }
            set {
                this.massField = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("rotate", typeof(Rotate), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("translate", typeof(TargetableFloat3), IsNullable=false)]
        public System.Collections.Generic.List<object> mass_frame {
            get {
                if ((this.mass_frameField == null)) {
                    this.mass_frameField = new System.Collections.Generic.List<object>();
                }
                return this.mass_frameField;
            }
            set {
                this.mass_frameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("inertia")]
        public TargetableFloat3 Inertia {
            get {
                return this.inertiaField;
            }
            set {
                this.inertiaField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("instance_physics_material", typeof(InstanceWithExtra))]
        [System.Xml.Serialization.XmlElementAttribute("physics_material", typeof(PhysicsMaterial))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("shape")]
        public System.Collections.Generic.List<InstanceRigidBodyTechniqueCommonShape> Shape {
            get {
                if ((this.shapeField == null)) {
                    this.shapeField = new System.Collections.Generic.List<InstanceRigidBodyTechniqueCommonShape>();
                }
                return this.shapeField;
            }
            set {
                this.shapeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InstanceRigidBodyTechniqueCommonDynamic {
        
        private string sidField;
        
        private bool valueField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. 
        ///This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InstanceRigidBodyTechniqueCommonShape {
        
        private InstanceRigidBodyTechniqueCommonShapeHollow hollowField;
        
        private TargetableFloat massField;
        
        private TargetableFloat densityField;
        
        private object itemField;
        
        private object item1Field;
        
        private object[] itemsField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        [System.Xml.Serialization.XmlElementAttribute("hollow")]
        public InstanceRigidBodyTechniqueCommonShapeHollow Hollow {
            get {
                return this.hollowField;
            }
            set {
                this.hollowField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("mass")]
        public TargetableFloat Mass {
            get {
                return this.massField;
            }
            set {
                this.massField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("density")]
        public TargetableFloat Density {
            get {
                return this.densityField;
            }
            set {
                this.densityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("instance_physics_material", typeof(InstanceWithExtra))]
        [System.Xml.Serialization.XmlElementAttribute("physics_material", typeof(PhysicsMaterial))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("box", typeof(Box))]
        [System.Xml.Serialization.XmlElementAttribute("capsule", typeof(Capsule))]
        [System.Xml.Serialization.XmlElementAttribute("cylinder", typeof(Cylinder))]
        [System.Xml.Serialization.XmlElementAttribute("instance_geometry", typeof(InstanceGeometry))]
        [System.Xml.Serialization.XmlElementAttribute("plane", typeof(Plane))]
        [System.Xml.Serialization.XmlElementAttribute("sphere", typeof(Sphere))]
        [System.Xml.Serialization.XmlElementAttribute("tapered_capsule", typeof(TaperedCapsule))]
        [System.Xml.Serialization.XmlElementAttribute("tapered_cylinder", typeof(TaperedCylinder))]
        public object Item1 {
            get {
                return this.item1Field;
            }
            set {
                this.item1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("rotate", typeof(Rotate))]
        [System.Xml.Serialization.XmlElementAttribute("translate", typeof(TargetableFloat3))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InstanceRigidBodyTechniqueCommonShapeHollow {
        
        private string sidField;
        
        private bool valueField;
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <summary>This element allows instancing a rigid_constraint within an instance_physics_model. 
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class InstanceRigidConstraint {
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string constraintField;
        
        private string sidField;
        
        private string nameField;
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The constraint attribute indicates which rigid_constraing to instantiate. Required attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("constraint", DataType="NCName")]
        public string Constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <summary>The sid attribute is a text string value containing the sub-identifier of this element. This 
        ///value must be unique within the scope of the parent element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sid", DataType="NCName")]
        public string Sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The library_physics_scenes element declares a module of physics_scene elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryPhysicsScenes {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<PhysicsScene> physics_sceneField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryPhysicsScenes> IDs = new System.Collections.Generic.Dictionary<string, LibraryPhysicsScenes>();
        
        /// <summary>The library_physics_scenes element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one physics_scene element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("physics_scene")]
        public System.Collections.Generic.List<PhysicsScene> PhysicsScene {
            get {
                if ((this.physics_sceneField == null)) {
                    this.physics_sceneField = new System.Collections.Generic.List<PhysicsScene>();
                }
                return this.physics_sceneField;
            }
            set {
                this.physics_sceneField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class PhysicsScene {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<InstanceWithExtra> instance_force_fieldField;
        
        private System.Collections.Generic.List<InstancePhysicsModel> instance_physics_modelField;
        
        private PhysicsSceneTechniqueCommon technique_commonField;
        
        private System.Collections.Generic.List<Technique> techniqueField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, PhysicsScene> IDs = new System.Collections.Generic.Dictionary<string, PhysicsScene>();
        
        /// <summary>The physics_scene element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There may be any number of instance_force_field elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_force_field")]
        public System.Collections.Generic.List<InstanceWithExtra> InstanceForceField {
            get {
                if ((this.instance_force_fieldField == null)) {
                    this.instance_force_fieldField = new System.Collections.Generic.List<InstanceWithExtra>();
                }
                return this.instance_force_fieldField;
            }
            set {
                this.instance_force_fieldField = value;
            }
        }
        
        /// <summary>There may be any number of instance_physics_model elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_physics_model")]
        public System.Collections.Generic.List<InstancePhysicsModel> InstancePhysicsModel {
            get {
                if ((this.instance_physics_modelField == null)) {
                    this.instance_physics_modelField = new System.Collections.Generic.List<InstancePhysicsModel>();
                }
                return this.instance_physics_modelField;
            }
            set {
                this.instance_physics_modelField = value;
            }
        }
        
        /// <summary>The technique_common element specifies the physics_scene information for the common profile 
        ///which all COLLADA implementations need to support.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique_common")]
        public PhysicsSceneTechniqueCommon TechniqueCommon {
            get {
                return this.technique_commonField;
            }
            set {
                this.technique_commonField = value;
            }
        }
        
        /// <summary>This element may contain any number of non-common profile techniques.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("technique")]
        public System.Collections.Generic.List<Technique> Technique {
            get {
                if ((this.techniqueField == null)) {
                    this.techniqueField = new System.Collections.Generic.List<Technique>();
                }
                return this.techniqueField;
            }
            set {
                this.techniqueField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The technique_common element specifies the physics_scene information for the common profile 
    ///which all COLLADA implementations need to support.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PhysicsSceneTechniqueCommon {
        
        private TargetableFloat3 gravityField;
        
        private TargetableFloat time_stepField;
        
        /// <summary>The gravity vector to use for the physics_scene.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("gravity")]
        public TargetableFloat3 Gravity {
            get {
                return this.gravityField;
            }
            set {
                this.gravityField = value;
            }
        }
        
        /// <summary>The time_step for the physics_scene.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("time_step")]
        public TargetableFloat TimeStep {
            get {
                return this.time_stepField;
            }
            set {
                this.time_stepField = value;
            }
        }
    }
    
    /// <summary>The library_visual_scenes element declares a module of visual_scene elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class LibraryVisualScenes {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<VisualScene> visual_sceneField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, LibraryVisualScenes> IDs = new System.Collections.Generic.Dictionary<string, LibraryVisualScenes>();
        
        /// <summary>The library_visual_scenes element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>There must be at least one visual_scene element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("visual_scene")]
        public System.Collections.Generic.List<VisualScene> VisualScene {
            get {
                if ((this.visual_sceneField == null)) {
                    this.visual_sceneField = new System.Collections.Generic.List<VisualScene>();
                }
                return this.visual_sceneField;
            }
            set {
                this.visual_sceneField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. 
        ///This value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The visual_scene element declares the base of the visual_scene hierarchy or scene graph. The 
    ///scene contains elements that comprise much of the visual and transformational information 
    ///content as created by the authoring tools.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class VisualScene {
        
        private Asset assetField;
        
        private System.Collections.Generic.List<Node> nodeField;
        
        private System.Collections.Generic.List<VisualSceneEvaluateScene> evaluate_sceneField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        private string idField;
        
        private string nameField;
        
        public static System.Collections.Generic.Dictionary<string, VisualScene> IDs = new System.Collections.Generic.Dictionary<string, VisualScene>();
        
        /// <summary>The visual_scene element may contain an asset element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("asset")]
        public Asset Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <summary>The visual_scene element must have at least one node element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("node")]
        public System.Collections.Generic.List<Node> Node {
            get {
                if ((this.nodeField == null)) {
                    this.nodeField = new System.Collections.Generic.List<Node>();
                }
                return this.nodeField;
            }
            set {
                this.nodeField = value;
            }
        }
        
        /// <summary>The evaluate_scene element declares information specifying a specific way to evaluate this 
        ///visual_scene. There may be any number of evaluate_scene elements.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("evaluate_scene")]
        public System.Collections.Generic.List<VisualSceneEvaluateScene> EvaluateScene {
            get {
                if ((this.evaluate_sceneField == null)) {
                    this.evaluate_sceneField = new System.Collections.Generic.List<VisualSceneEvaluateScene>();
                }
                return this.evaluate_sceneField;
            }
            set {
                this.evaluate_sceneField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
        
        /// <summary>The id attribute is a text string containing the unique identifier of this element. This 
        ///value must be unique within the instance document. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                IDs[value] = this;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The evaluate_scene element declares information specifying a specific way to evaluate this 
    ///visual_scene. There may be any number of evaluate_scene elements.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class VisualSceneEvaluateScene {
        
        private System.Collections.Generic.List<VisualSceneEvaluateSceneRender> renderField;
        
        private string nameField;
        
        /// <summary>The render element describes one effect pass to evaluate the scene.
        ///There must be at least one render element.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("render")]
        public System.Collections.Generic.List<VisualSceneEvaluateSceneRender> Render {
            get {
                if ((this.renderField == null)) {
                    this.renderField = new System.Collections.Generic.List<VisualSceneEvaluateSceneRender>();
                }
                return this.renderField;
            }
            set {
                this.renderField = value;
            }
        }
        
        /// <summary>The name attribute is the text string name of this element. Optional attribute.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType="NCName")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>The render element describes one effect pass to evaluate the scene.
    ///There must be at least one render element.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class VisualSceneEvaluateSceneRender {
        
        private System.Collections.Generic.List<string> layerField;
        
        private InstanceEffect instance_effectField;
        
        private string camera_nodeField;
        
        /// <summary>The layer element specifies which layer to render in this compositing step 
        ///while evaluating the scene. You may specify any number of layers.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("layer", DataType="NCName")]
        public System.Collections.Generic.List<string> Layer {
            get {
                if ((this.layerField == null)) {
                    this.layerField = new System.Collections.Generic.List<string>();
                }
                return this.layerField;
            }
            set {
                this.layerField = value;
            }
        }
        
        /// <summary>The instance_effect element specifies which effect to render in this compositing step 
        ///while evaluating the scene.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_effect")]
        public InstanceEffect InstanceEffect {
            get {
                return this.instance_effectField;
            }
            set {
                this.instance_effectField = value;
            }
        }
        
        /// <summary>The camera_node attribute refers to a node that contains a camera describing the viewpoint to 
        ///render this compositing step from.
        ///</summary>
        [System.Xml.Serialization.XmlAttributeAttribute("camera_node", DataType="anyURI")]
        public string CameraNode {
            get {
                return this.camera_nodeField;
            }
            set {
                this.camera_nodeField = value;
            }
        }
    }
    
    /// <summary>The scene embodies the entire set of information that can be visualized from the 
    ///contents of a COLLADA resource. The scene element declares the base of the scene 
    ///hierarchy or scene graph. The scene contains elements that comprise much of the 
    ///visual and transformational information content as created by the authoring tools.
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class COLLADAScene {
        
        private System.Collections.Generic.List<InstanceWithExtra> instance_physics_sceneField;
        
        private InstanceWithExtra instance_visual_sceneField;
        
        private System.Collections.Generic.List<Extra> extraField;
        
        /// <summary>The instance_physics_scene element declares the instantiation of a COLLADA physics_scene resource.
        ///The instance_physics_scene element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_physics_scene")]
        public System.Collections.Generic.List<InstanceWithExtra> InstancePhysicsScene {
            get {
                if ((this.instance_physics_sceneField == null)) {
                    this.instance_physics_sceneField = new System.Collections.Generic.List<InstanceWithExtra>();
                }
                return this.instance_physics_sceneField;
            }
            set {
                this.instance_physics_sceneField = value;
            }
        }
        
        /// <summary>The instance_visual_scene element declares the instantiation of a COLLADA visual_scene resource.
        ///The instance_visual_scene element may only appear once.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("instance_visual_scene")]
        public InstanceWithExtra InstanceVisualScene {
            get {
                return this.instance_visual_sceneField;
            }
            set {
                this.instance_visual_sceneField = value;
            }
        }
        
        /// <summary>The extra element may appear any number of times.
        ///</summary>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public System.Collections.Generic.List<Extra> Extra {
            get {
                if ((this.extraField == null)) {
                    this.extraField = new System.Collections.Generic.List<Extra>();
                }
                return this.extraField;
            }
            set {
                this.extraField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema")]
    public enum VersionType {
        
        [System.Xml.Serialization.XmlEnumAttribute("1.4.0")]
        Item140,
        
        [System.Xml.Serialization.XmlEnumAttribute("1.4.1")]
        Item141,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd2net", "0.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=false)]
    public partial class Ellipsoid {
        
        private string sizeField;
        
        [System.Xml.Serialization.XmlElementAttribute("size")]
        public string Size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
    }
}
