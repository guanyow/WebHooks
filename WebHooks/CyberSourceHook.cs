using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DeliverEatRevamp
{
    public class CyberSourceHook
    {
        public string auth_cv_result { get; set; }
        public string req_locale { get; set; }
        public string req_card_type_selection_indicator { get; set; }
        public string auth_trans_ref_no { get; set; }
        public string payer_authentication_enroll_veres_enrolled { get; set; }
        public string req_bill_to_surname { get; set; }
        public string payer_authentication_proof_xml { get; set; }
        public string req_card_expiry_date { get; set; }
        public string req_bill_to_phone { get; set; }
        public string card_type_name { get; set; }

        public string auth_amount { get; set; }
        public string auth_response { get; set; }
        public string req_payment_method { get; set; }
        public bool auth_time { get; set; }
        public string transaction_id { get; set; }
        public string req_card_type { get; set; }

        public string auth_avs_code { get; set; }
        public string auth_code { get; set; }
        public string req_bill_to_company_name { get; set; }
    }
}


