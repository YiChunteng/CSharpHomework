<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" 
                xmlns:xsd="http://www.w3.org/2001/XMLSchema" version="1.0">
<xsl:output method='html' version='1.0' encoding='UTF-8' indent='yes'/>
  <xsl:template match="/">
    <html>
      <head>
        <title> Orders </title>
      </head>
      <body>
       <h2>Order Form</h2>
        <table border="1" cellspacing="0" cellspadding="0">
                          <tr>
                                <th>id</th>
                                <th>costumer</th>
                            <th>PhoneNumber</th>
                              <th>Details</th>
                          </tr>
          <xsl:for-each select="ArrayOfOrder/Order">
         <tr>          
              <td><xsl:value-of select="Id"/></td>
               <td><xsl:value-of select="Customer/Name"/> </td>
            <td><xsl:value-of select="PhoneNum"/></td>
             <td>
               <xsl:apply-templates select="Details"></xsl:apply-templates>
               
             </td>
         </tr>
          </xsl:for-each>
        </table>       
      </body>
    </html>
  </xsl:template>
  <xsl:template match="Details">
    <xsl:for-each select="OrderDetail">
      商品：<xsl:value-of select="Goods/Name"/><br/>
      价格：<xsl:value-of select="Goods/Price"/><br/>
      数量：<xsl:value-of select="Quantity"/><br/>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>